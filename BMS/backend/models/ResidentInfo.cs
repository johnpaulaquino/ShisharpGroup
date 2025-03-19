using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.utils;

namespace BMS.backend.database.models {

    public enum Gender {
        Male,
        Female,
        Others
    }

    public class ResidentInfo {
        public string id = Guid.NewGuid().ToString();
        public string userId { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string gender { get; set; }


        public ResidentInfo(
            string firstname,
            string middlename,
            string lastname,
            string email,
            Gender gender){

            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.gender = gender.ToString();
            this.email = email;

        }
        public override string ToString() {
            return $"id: {this.id}\nGender: {this.gender}";
        }

    }
}