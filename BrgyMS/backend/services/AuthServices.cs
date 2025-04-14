using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.utils;
using BrgyMs.backend.database.repositories;


namespace BrgyMs.backend.services {

    public class AuthServices {
        private readonly AuthUtils _AuthUtils = new AuthUtils();
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();
        public AuthServices() {
        }
        public async Task<bool> AuthenticateUser(string Email, string Password) {
            Dictionary<string, string> data = await _ResidentRepo.GetEmail(Email);
           
            if (Password.Length <= 0 && Email.Length <= 0)
            {
                throw new Exception("Username and Password should not be empty!");
            }

            if (Email.Length <= 0)
            {
                throw new Exception("Username should not be empty!");
            }
            if (Password.Length <= 0)
            {
                throw new Exception("Password should not be empty!");
            }
           

            if (data.Count == 0) {
                throw new Exception("Incorrect Username!");
            }
            if (data["status"] == "0") {
                throw new Exception("It seems you have an account, but not verified yet!");
            }

           
            if (!_AuthUtils.verifyHashedPassword(Password, data["password"])) {
                throw new Exception("Incorrect Password!");
            }
            return true;
        }
    }
}