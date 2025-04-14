using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotNetEnv;

namespace BrgyMs.backend.variables {
    public class Settings {
        public readonly string DB_NAME;
        public readonly string EMAIL;
        public readonly string EMAIL_PASSWORD;
        public readonly string EMAIL_SERVER;
        public readonly int EMAIL_PORT;
        public readonly string EMAIL_USERNAME;
        public Settings() {
            Env.Load(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\.env"));

            DB_NAME = Env.GetString("DB_NAME");
            EMAIL = Env.GetString("EMAIL");
            EMAIL_PASSWORD = Env.GetString("EMAIL_PASSWORD");
            EMAIL_SERVER = Env.GetString("EMAIL_SERVER");
            EMAIL_PORT = Env.GetInt("EMAIL_PORT");
            EMAIL_USERNAME = Env.GetString("EMAIL_USERNAME");
        }

    }
}