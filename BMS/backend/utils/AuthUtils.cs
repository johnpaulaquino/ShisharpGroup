using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Isopoh.Cryptography.Argon2;
using Isopoh.Cryptography.SecureArray;


namespace BackEnd.utils
{

    
    public class AuthUtils
{
    

    public AuthUtils(){
    }

    public string hashedPassword(string plainPassword){
      return Argon2.Hash(plainPassword);
    }

    public bool verifyHashedPassword(String plainPassword, String hashedPassword){

            
    if (string.IsNullOrEmpty(hashedPassword) ||
         string.IsNullOrEmpty(plainPassword)){
        return false; 
    }
            return Argon2.Verify(plainPassword, hashedPassword);

    }


    
}   
    
}