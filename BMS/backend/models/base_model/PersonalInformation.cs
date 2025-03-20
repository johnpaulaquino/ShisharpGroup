using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.base_model {
    public class PersonalInformation {
        public string Id = Guid.NewGuid().ToString();
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; } // Male, Female, and Other
        public string Category { get; set; } // Resident, Admin, and Officials


        public PersonalInformation(
            string Firstname,
            string Middlename,
            string Lastname,
            string Gender,
            string Category
) {

            this.Firstname = Firstname;
            this.Middlename = Middlename;
            this.Lastname = Lastname;
            this.Gender = Gender;
            this.Category = Category;

        }

        public override string ToString() {
            return $"id: {this.Id}\nGender: {this.Gender}";
        }
    }
}