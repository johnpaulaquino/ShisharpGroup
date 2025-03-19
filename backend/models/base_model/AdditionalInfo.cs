using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.utils;

namespace BMS.backend.models.base_model {
    public class AdditionalInfo {

        public Utils utils = new Utils();
        public string id = Guid.NewGuid().ToString();
        public int[] profileImage { get; set; }
        public bool isVoter { get; set; }
        public string maritalStatus { get; set; } // Single, Widowed, Married, and Divorce
        public string empStatus { get; set; } // Employee, Self-employed, Unemployed, Volunteer
        public string educAttain { get; set; } // Elementary, Junior High School, Senior High School, College, Masteral, Docotrate, and None
        public DateTime birthDate;
        public int age { get; }

        public AdditionalInfo(
                            bool isVoter,
                            DateTime birthDate,
                            string empStatus,
                            string educAttain,
                            string maritalStatus,
                            int[] profileImage) {
            this.profileImage = profileImage;
            this.birthDate = birthDate;
            this.isVoter = isVoter;
            age = utils.calculateAge(this.birthDate);
            this.educAttain = educAttain;
            this.maritalStatus = maritalStatus;
            this.empStatus = empStatus;
        }
    }
}