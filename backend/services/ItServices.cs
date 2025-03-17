using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.database.repositories;
using BMS.backend.models;

namespace BMS.backend.services {
    public class ItServices {
        private readonly ITRepository itRepo = new ITRepository();
        private readonly AdminReposiroty adminRepo = new AdminReposiroty();
        public ItServices() {

        }

        public async Task AddAdminUserAccountServices(AdminUser admin) {
            try {
                Dictionary<string, string> data = await itRepo.GetInfoByEmail(admin.email);
                if (data.Count > 0) {
                    throw new Exception("User already Exist!");
                }
                await itRepo.InsertAdminUser(admin);
            }
            catch (System.Exception) {

                throw;
            }
        }// end of the Add admin account function


        public async Task UpdateAdminServices(AdminUser admin, string email) {
            try {
                Dictionary<string, string> data = await itRepo.GetInfoById(email);
                if (data.Count == 0) {
                    throw new Exception("No user found!");
                }

                await itRepo.UpdateAdminInfo(data, admin);
            }
            catch (System.Exception) {

                throw;
            }
        }// End of the update Function

        public async Task DeleteAdminInfo(string email) {
            try {
                Dictionary<string, string> Data = await itRepo.GetInfoByEmail(email);
                if (Data.Count == 0) {
                    throw new Exception("No user found!");
                }

                await adminRepo.DeleteAdminUser(Data["id"]);
            }
            catch (System.Exception) {

                throw;
            }
        }
    }
}