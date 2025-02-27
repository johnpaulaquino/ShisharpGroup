using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.utils;
using BMS.backend.database.repositories;


namespace BMS.backend.services
{

    public class AuthServices
    {
        AuthUtils utility = new AuthUtils();
        ITRepository itRepo = new ITRepository();
        public AuthServices()
        {

        }
        public async Task<Dictionary<string, string>> authenticateAdmin(string email, string plainPassword)
        {
            Dictionary<string, string> data = await itRepo.GetInfoByEmail(email);


            if (data == null || data.Count == 0)
            {
                throw new Exception("Incorrect Username!");

            }

            if (!utility.verifyHashedPassword(plainPassword, data["password"]))
            {
                throw new Exception("Incorrect Password!");
            }
            data.Remove("password");
            return data;
        }
    }
}