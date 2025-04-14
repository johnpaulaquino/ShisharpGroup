using Isopoh.Cryptography.Argon2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;



namespace BrgyMs.backend.utils
{


    public class AuthUtils
    {
        public string hashedPassword(string plainPassword)
        {
            return Argon2.Hash(plainPassword);
        }

        public bool verifyHashedPassword(string plainPassword, string hashedPassword)
        {


            if (string.IsNullOrEmpty(hashedPassword) ||
                string.IsNullOrEmpty(plainPassword))
            {
                return false;
            }
          

            return Argon2.Verify(hashedPassword, plainPassword);

        }
    }
}