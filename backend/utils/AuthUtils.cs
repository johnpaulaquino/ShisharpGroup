using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Isopoh.Cryptography.Argon2;
using Isopoh.Cryptography.SecureArray;


namespace BackEnd.utils {


    public class AuthUtils {
        public string hashedPassword(string plainPassword) {
            return Argon2.Hash(plainPassword);
        }

        public bool verifyHashedPassword(string plainPassword, string hashedPassword) {


            if (string.IsNullOrEmpty(hashedPassword) ||
                string.IsNullOrEmpty(plainPassword)) {
                Console.WriteLine("Hey");
                return false;
            }

            return Argon2.Verify(hashedPassword, plainPassword);

        }


        public bool authenticateUser(Dictionary<string, string> data, string plainPassword) {

            if (data == null || data.Count == 0) {
                throw new Exception("User not found!");

            }

            if (!this.verifyHashedPassword(plainPassword, data["password"])) {
                throw new Exception("Incorrect Password!");
            }

            return true;
        }

    }
}