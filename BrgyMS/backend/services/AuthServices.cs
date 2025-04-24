using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.utils;
using BrgyMs.backend.database.repositories;
using BrgyMS.backend.models;


namespace BrgyMs.backend.services {

    public class AuthServices {
        private readonly AuthUtils _AuthUtils = new AuthUtils();
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();
        private string Status = "users";
        public AuthServices() {
        }
        public async Task<bool> AuthenticateUser(string Email, string Password) {

            try {
                Dictionary<string, string> data = await _ResidentRepo.GetEmail(Email);
                if (Password.Length <= 0 && Email.Length <= 0) {
                    throw new Exception("Username and Password should not be empty!");
                }

                if (Email.Length <= 0) {
                    throw new Exception("Username should not be empty!");
                }
                if (Password.Length <= 0) {
                    throw new Exception("Password should not be empty!");
                }


                if (data == null) {
                    throw new Exception("Incorrect Username!");
                }
                if (data["status"] == "0") {
                    throw new Exception("It seems you have an account, but not verified yet!");
                }


                if (!_AuthUtils.verifyHashedPassword(Password, data["password"])) {
                    throw new Exception("Incorrect Password!");
                }

                Status = data["role"];

                _AuthUtils.GenerateToken(data); // Generate Token after login

               
                string id = await _ResidentRepo.GenerateLogsId(); // id generated
                var logs = new Logs(id, data["userId"],  // Logs Object
                    new DateTime(), "Login");

                //log actions
                await _ResidentRepo.LogUserActions(logs);

                return true;
            }
            catch (Exception e) {
                throw;
            }

        }

        public string GetStatus() {
            return Status;
        }
    }
}