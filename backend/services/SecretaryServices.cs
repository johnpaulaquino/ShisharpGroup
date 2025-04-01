using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.data_validation;
using BMS.backend.database.repositories;
using BMS.backend.models.base_model;
using BMS.backend.models.bo_model;

using MySql.Data.MySqlClient;

namespace BMS.backend.services {
    public class SecretaryServices {
        ResidentRepository _ResidentRepo = new ResidentRepository();
        UserInfoValidation _Validation = new UserInfoValidation();

        public SecretaryServices() {

        }
        public async Task CreateOfficialsInfo(User _User,
            PersonalInformation _PersonalInfo,
            AdditionalInfo _AdditionalInfo,
            Address _ResidentAddress,
            OfficialsInfo _OfficialsInfo,
            ElectionHistories _ElectionHistories
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
                await _ResidentRepo.AddOfficialsInfo(_OfficialsInfo, _ElectionHistories, Id);
            }
            catch (System.Exception) {

                throw;
            }
        }//End of function


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
            catch (System.Exception) {

                throw;
            }
        }//End of function

        public async Task<DbDataReader> GetResidentInformation() {
            var reader = await _ResidentRepo.GetInformation();
            return reader;
        }
    }
}