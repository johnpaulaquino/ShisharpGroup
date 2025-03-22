using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.residents_model;
using BMS.backend.database.repositories;
using BMS.backend.models.base_model;
using BMS.backend.models.bo_model;
using System.Data.Common;

namespace BMS.backend.services {
    public class AdminServices {
        ResidentRepository _ResidentRepo = new ResidentRepository();
        public AdminServices() {

        }
        public async Task CreateOfficialsInformation(User _User,
            PersonalInformation _ResidentInfo,
            ResidentAdditionalInfo _ResidentAddInfo,
            Address _ResidentAddress,
            OfficialsInfo _OfficialsInfo,
            ElectionHistories _ElectionHistories
            ) {

            try {
                Dictionary<string, string> IsExist = await _ResidentRepo.GetEmail(_User.Email);
                if (IsExist.Count > 0) {
                    throw new Exception("Email is already exist, Email must be unique!");
                }
                await _ResidentRepo.AddUser(_User);
                await _ResidentRepo.AddResidentInformation(_ResidentInfo, _User.id);
                await _ResidentRepo.AddResidentAddInfo(_ResidentAddInfo, _ResidentInfo.Id);
                await _ResidentRepo.AddResidentAddress(_ResidentAddress, _ResidentInfo.Id);
                await _ResidentRepo.AddOfficialsInfo(_OfficialsInfo, _ElectionHistories, _ResidentInfo.Id);
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