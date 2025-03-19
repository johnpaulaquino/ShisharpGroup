using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.base_model {
    public class PersonalInformation {
        public string id = Guid.NewGuid().ToString();
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string gender { get; set; } // Male, Female, and Other
        public string category { get; set; } // Resident, Admin, and Officials

        public PersonalInformation(
            string email,
            string firstname,
            string middlename,
            string lastname,
            string gender,
            string category) {

            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.email = email;
            this.gender = gender;
            this.category = category;
        }

        public override string ToString() {
            return $"id: {this.id}\nGender: {this.gender}";
        }
    }
}