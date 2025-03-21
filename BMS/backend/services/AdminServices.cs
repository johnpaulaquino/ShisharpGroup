using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.residents_model;
using BMS.backend.database.repositories;
using BMS.backend.models.base_model;

namespace BMS.backend.services {
    public class AdminServices {
        ResidentRepository _AdminRepo = new ResidentRepository();
        public AdminServices() {

        }

        public async Task AddResidentFullformation(
            PersonalInformation _ResidentInfo,
            ResidentAdditionalInfo _ResidentAddInfo,
            Address _ResidentAddress
            ) {

            try {
                Dictionary<string, string> IsExist = await _AdminRepo.FindResidentById(_ResidentInfo.Id);
                if (IsExist.Count > 0) {
                    throw new Exception("Email is already exist, Email must be unique!");
                }

                await _AdminRepo.AddResidentInformation(_ResidentInfo);
                await _AdminRepo.AddResidentAddInfo(_ResidentAddInfo, _ResidentInfo.Id);
                await _AdminRepo.AddResidentAddress(_ResidentAddress, _ResidentInfo.Id);

            }
            catch (System.Exception) {

                throw;
            }
        }
    }
}