using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.data_validation;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;

using MySql.Data.MySqlClient;

namespace BrgyMs.backend.services {
    public class SecretaryServices {
        ResidentRepository _ResidentRepo = new ResidentRepository();
        UserInfoValidation _Validation = new UserInfoValidation();

        public SecretaryServices() {

        }

        public async Task CreateResidentInfo(User _User,
            PersonalInformation _PersonalInfo,
            AdditionalInfo _AdditionalInfo,
            Address _ResidentAddress
            ) {

            try {
                Dictionary<string, string> IsExist = await _ResidentRepo.GetEmail(_User.Email);
                if (IsExist.Count > 0) {
                    throw new Exception("Email is already exist, Email must be unique!");
                }
                _Validation.ValidateUser(_User);
                _Validation.ValidatePersonalInfo(_PersonalInfo);
                _Validation.ValidateAddInfo(_AdditionalInfo);


                string Id = await _ResidentRepo.GenerateId();
                await _ResidentRepo.AddUser(_User);
                await _ResidentRepo.AddResidentInformation(_PersonalInfo, Id);
                await _ResidentRepo.AddResidentAddInfo(_AdditionalInfo, Id);
                await _ResidentRepo.AddResidentAddress(_ResidentAddress, Id);
            }
            catch (System.Exception e) {

                throw e;
            }
        }//End of function

       
    }
}