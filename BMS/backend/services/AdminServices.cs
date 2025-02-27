using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BMS.backend.database.repositories;
using BMS.backend.models.base_model;
using BMS.backend.models.bo_model;
using System.Data.Common;
using BMS.backend.data_validation;

namespace BMS.backend.services
{
    public class AdminServices
    {
        ResidentRepository _ResidentRepo = new ResidentRepository();
        UserInfoValidation _Validation = new UserInfoValidation();
        public AdminServices()
        {

        }
        public async Task CreateOfficialsInfo(User _User,
            PersonalInformation _PersonalInfo,
            AdditionalInfo _AdditionalInfo,
            Address _ResidentAddress,
            OfficialsInfo _OfficialsInfo,
            ElectionHistories _ElectionHistories
            )
        {

            try
            {
                Dictionary<string, string> IsExist = await _ResidentRepo.GetEmail(_User.Email);
                if (IsExist.Count > 0)
                {
                    throw new Exception("Email is already exist, Email must be unique!");
                }
                _Validation.ValidateUser(_User);
                _Validation.ValidatePersonalInfo(_PersonalInfo);
                _Validation.ValidateAddInfo(_AdditionalInfo);

                await _ResidentRepo.AddUser(_User);
                await _ResidentRepo.AddResidentInformation(_PersonalInfo, _User.id);
                await _ResidentRepo.AddResidentAddInfo(_AdditionalInfo, _User.id);
                await _ResidentRepo.AddResidentAddress(_ResidentAddress, _User.id);
                await _ResidentRepo.AddOfficialsInfo(_OfficialsInfo, _ElectionHistories, _User.id);
            }
            catch (System.Exception)
            {

                throw;
            }
        }//End of function


        public async Task CreateResidentInfo(User _User,
            PersonalInformation _PersonalInfo,
            AdditionalInfo _AdditionalInfo,
            Address _ResidentAddress
            )
        {

            try
            {
                Dictionary<string, string> IsExist = await _ResidentRepo.GetEmail(_User.Email);
                if (IsExist.Count > 0)
                {
                    throw new Exception("Email is already exist, Email must be unique!");
                }
                _Validation.ValidateUser(_User);
                _Validation.ValidatePersonalInfo(_PersonalInfo);
                _Validation.ValidateAddInfo(_AdditionalInfo);

                await _ResidentRepo.AddUser(_User);
                await _ResidentRepo.AddResidentInformation(_PersonalInfo, _User.id);
                await _ResidentRepo.AddResidentAddInfo(_AdditionalInfo, _User.id);
                await _ResidentRepo.AddResidentAddress(_ResidentAddress, _User.id);
            }
            catch (System.Exception)
            {

                throw;
            }
        }//End of function

        public async Task<DbDataReader> GetResidentInformation()
        {
            var reader = await _ResidentRepo.GetInformation();
            return reader;
        }
    }
}