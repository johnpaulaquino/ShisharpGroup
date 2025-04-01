using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.data_validation;
using BMS.backend.database.repositories;
using BMS.backend.models.base_model;
using BMS.backend.models.bo_model;
using BMS.backend.models.residents_model;



namespace BMS.backend.services {

    public class ResidentServices {
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();
        private readonly UserInfoValidation _Validation = new UserInfoValidation();



        public async Task CreateResidentInformation(User _User,
            PersonalInformation _ResidentInfo,
            AdditionalInfo _AdditionalInfo,
            Address _ResidentAddress

            ) {

            try {
                Dictionary<string, string> IsExist = await _ResidentRepo.GetEmail(_User.Email);
                if (IsExist.Count > 0) {
                    throw new Exception("Email is already exist, Email must be unique!");
                }

                string Id = await _ResidentRepo.GenerateId();
                await _ResidentRepo.AddUser(_User);
                await _ResidentRepo.AddResidentInformation(_ResidentInfo, Id);
                await _ResidentRepo.AddResidentAddInfo(_AdditionalInfo, Id);
                await _ResidentRepo.AddResidentAddress(_ResidentAddress, Id);

            }
            catch (System.Exception) {

                throw;
            }
        } // End of function

        public async Task CreateResidentDocument(ResidentDocumentRequest _RequestDocs) {
            try {

                //Validate fields first before insertion.
                _Validation.ValdiateRequestDocs(_RequestDocs);
                // Insert data on database
                await _ResidentRepo.AddRequestDocuments(_RequestDocs);

            }
            catch (System.Exception) {
                throw;
            }
        }



    }


}