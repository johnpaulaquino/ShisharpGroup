using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.data_validation;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.residents_model;
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

                //Validate fields first before insertion.
                _Validation.ValdiateRequestDocs(_RequestDocs);
         
                // Insert data on database
                await _ResidentRepo.AddRequestDocuments(_RequestDocs);

            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        } // end of the function

        public async Task<MySqlDataAdapter> GetUsersLogs(int limit) {
            try {
                return await _ResidentRepo.GetUserLogs(limit);
            }
            catch (Exception) {
                throw;
            }
        }// end of function
    

        //Get the request documnts

        public async Task<MySqlDataAdapter> GetRequestDocuments(string userId, int limit) {
            try {
                return await _ResidentRepo.GetRequestedDocs(userId, limit);
            }
            catch (Exception) {
                throw;
            }
        }

    }


}