using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.utils;
using BMS.backend.database.repositories;


namespace BMS.backend.services {

    public class AuthServices {
        private readonly AuthUtils _AuthUtils = new AuthUtils();
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();
        public AuthServices() {
        }
        public async Task<bool> AuthenticateUser(string Email, string Password) {
            Dictionary<string, string> data = await _ResidentRepo.GetEmail(Email);

            if (data.Count == 0) {
                throw new Exception("Incorrect Username!");
            }
            if (data["status"] == "0") {
                throw new Exception("It seems you have an account, but not verified yet!");
            }

            if (!_AuthUtils.verifyHashedPassword(Password, data["password"])) {
                throw new Exception("Incorrect password!");
            }
            return true;
        }
    }
}