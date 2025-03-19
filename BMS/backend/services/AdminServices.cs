using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.residents_model;
using BMS.database.respositories;

namespace BMS.backend.services {
    public class AdminServices {
        UserRepository _AdminRepo = new UserRepository();
        public AdminServices() {

        }

        public async Task AddResidentFullformation(
            ResidentInfo _ResidentInfo,
            ResidentAdditionalInfo _ResidentAddInfo,
            ResidentAddress _ResidentAddress
            ) {

            try {
                Dictionary<string, string> IsExist = await _AdminRepo.FindResidentByEmail(_ResidentInfo.email);
                if (IsExist.Count > 0) {
                    throw new Exception("Email is already exist, Email must be unique!");
                }

                await _AdminRepo.AddResidentInformation(_ResidentInfo);
                await _AdminRepo.AddResidentAddInfo(_ResidentAddInfo, _ResidentInfo.id);
                await _AdminRepo.AddResidentAddress(_ResidentAddress, _ResidentInfo.id);

            }
            catch (System.Exception) {

                throw;
            }
        }
    }
}