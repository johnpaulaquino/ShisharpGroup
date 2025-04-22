using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotNetEnv;

namespace BrgyMs.backend {
    public class Settings {
        //db configuration
        public readonly string DB_NAME;
        public readonly string DB_USERNAME;
        public readonly string DB_PASSWORD;
        public readonly string DB_PORT;
        public readonly string DB_SERVER;

        //token
        public readonly string TOKEN_SECRET_KEY;
        public readonly string ISSUER;
        public readonly string AUDIENCE;

        //email configuration
        public readonly string EMAIL;
        public readonly string EMAIL_PASSWORD;
        public readonly string EMAIL_SERVER;
        public readonly int EMAIL_PORT;
        public readonly string EMAIL_USERNAME;
        
        public Settings() {
            Env.Load(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\.env"));
            //DB
            DB_NAME = Env.GetString("DB_NAME");
            DB_USERNAME = Env.GetString("DB_USERNAME");
            DB_PASSWORD = Env.GetString("DB_PASSWORD");
            DB_PORT = Env.GetString("DB_PORT");
            DB_SERVER = Env.GetString("DB_SERVER");

            //token 
            TOKEN_SECRET_KEY = Env.GetString("TOKEN_SECRET_KEY");
            ISSUER = Env.GetString("ISSUER");
            AUDIENCE = Env.GetString("AUDIENCE");

            //EMAIL
            EMAIL = Env.GetString("EMAIL");
            EMAIL_PASSWORD = Env.GetString("EMAIL_PASSWORD");
            EMAIL_SERVER = Env.GetString("EMAIL_SERVER");
            EMAIL_PORT = Env.GetInt("EMAIL_PORT");
            EMAIL_USERNAME = Env.GetString("EMAIL_USERNAME");
        }

    }
}