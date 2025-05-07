using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.data_validation;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.residents_docs;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using MySql.Data.MySqlClient;



namespace BrgyMs.backend.services {

    public class ResidentServices : BaseServices {
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();
        private readonly UserInfoValidation _Validation = new UserInfoValidation();

        public async Task CreateResidentInformation(User _User,
            PersonalInformation _ResidentInfo,
            AdditionalInfo _AdditionalInfo,
            Address _ResidentAddress
            ) {
            try {

                string Id = await _ResidentRepo.GenerateUsersId();

                await _ResidentRepo.AddUser(_User);
                await _ResidentRepo.InsertUserPersonalInformation(_ResidentInfo, Id);
                await _ResidentRepo.InsertUserAddinfo(_AdditionalInfo, Id);
                await _ResidentRepo.InsertUserAddress(_ResidentAddress, Id);
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        } // End of function

        public async Task CreateResidentDocument(ResidentDocumentRequest _RequestDocs) {
            try {

                if (await _ResidentRepo.IsUserRequested(_RequestDocs.UserId)) {
                    throw new Exception("Please wait for the approval of you requested document!");
                }
                //Validate fields first before insertion.
                _Validation.ValidateRequestDocs(_RequestDocs);


                // Insert data on database
                await _ResidentRepo.AddRequestDocuments(_RequestDocs);

            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        } // end of the function


        //Get user logs per users
        public async Task<MySqlDataAdapter> GetUsersLogs(string userId) {
            try {
                return await _ResidentRepo.GetUserLogs(userId);
            }
            catch (Exception) {
                throw;
            }
        }// end of function


        //Get the request documnts

        public async Task<MySqlDataAdapter> GetRequestDocuments(string userId) {
            try {
                return await _ResidentRepo.GetRequestedDocs(userId);
            }
            catch (Exception) {
                throw;
            }
        }// end 


        public async Task<List<AnnouncementsModel>> GetAnnouncement() {
            try {
                List<AnnouncementsModel> data = await _ResidentRepo.GetAnnouncement();
                return data;
            }
            catch (Exception) {
                throw;
            }
        } // end

        public async Task UpdateResidentRequestDocs(string id,
            string doc_type,
            string purpose, string others) {
            try {
                var docs = new ResidentDocumentRequest()
                {
                    DocumentType = doc_type,
                    Purpose = purpose
                };
                _Validation.ValidateRequestDocs(docs); // validate

                await _ResidentRepo.UpdateRequestDocs(id, doc_type, purpose, others); // then update
            }
            catch (Exception) {
                throw;
            }

        } // 
        public async Task<DataTable> GetRequestDocs(string userid) {
            try {
                DataTable dt = await Task.Run(async () =>
                {
                    return await _ResidentRepo.GetRequestedDocs1(userid);
                });

                return dt;
            }
            catch (Exception) {
                throw;
            }
        }

    }


}