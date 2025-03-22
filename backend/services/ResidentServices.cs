using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.database.repositories;
using BMS.backend.models.base_model;
using BMS.backend.models.bo_model;
using BMS.backend.models.residents_model;

namespace BMS.backend.services {

    public class ResidentServices {
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();



        public async Task CreateResidentInformation(User _User,
            PersonalInformation _ResidentInfo,
            ResidentAdditionalInfo _ResidentAddInfo,
            Address _ResidentAddress

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

            }
            catch (System.Exception) {

                throw;
            }
        }

    }


}