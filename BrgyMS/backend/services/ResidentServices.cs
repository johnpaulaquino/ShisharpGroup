using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.data_validation;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.residents_model;
using BrgyMS.backend.services;



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
               
                string Id = await _ResidentRepo.GenerateId();

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
        }
    }


}