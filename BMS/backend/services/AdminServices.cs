using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.database.models;
using BMS.backend.database.repositories;

namespace BMS.backend.services {
    public class AdminServices {
        AdminReposiroty _AdminRepo = new AdminReposiroty();
        public AdminServices() {

        }

        public async Task AddResidentFullformation(
            ResidentInfo _ResidentInfo,
            ResidentAdditionalInfo _ResidentAddInfo,
            ResidentAddress _ResidentAddress,
            string _ResidentInfoId
            ) {

            try {
                Dictionary<string, string> IsExist = await _AdminRepo.FindResidentByEmail(_ResidentInfo.email);
                if (IsExist.Count > 0) {
                    throw new Exception("Email is already exist, Email must be unique!");
                }
                
                await _AdminRepo.AddResidentInformation(_ResidentInfo);
                await _AdminRepo.AddResidentAddInfo(_ResidentAddInfo, _ResidentInfoId);
                await _AdminRepo.AddResidentAddress(_ResidentAddress, _ResidentInfoId);

            }
            catch (System.Exception) {

                throw;
            }
        }
    }
}