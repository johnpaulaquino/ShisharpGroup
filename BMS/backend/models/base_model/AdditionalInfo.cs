using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.utils;

namespace BMS.backend.models.base_model {
    public class AdditionalInfo {

        public Utils utils = new Utils();
        public string ID = Guid.NewGuid().ToString();
        public int[] ProfileImage { get; set; }
        public bool IsVoter { get; set; }
        public string MaritalStatus { get; set; } // Single, Widowed, Married, and Divorce
        public string EmpStatus { get; set; } // Employee, Self-employed, Unemployed, Volunteer
        public string EducAttain { get; set; } // Elementary, Junior High School, Senior High School, College, Masteral, Docotrate, and None
        public DateTime BirthDate;
        public int Age { get; }
        public string ContactNo { get; set; }
        public string Status { get; set; } // enable and disabled

        public AdditionalInfo(
                            bool IsVoter,
                            DateTime BirthDate,
                            string EmpStatus,
                            string EducAttain,
                            string MaritalStatus,
                            string ContactNo,
                            string Status,
                            int[] ProfileImage) {
            this.ProfileImage = ProfileImage;
            this.BirthDate = BirthDate;
            this.IsVoter = IsVoter;
            Age = utils.calculateAge(this.BirthDate);
            this.EducAttain = EducAttain;
            this.MaritalStatus = MaritalStatus;
            this.EmpStatus = EmpStatus;
            this.ContactNo = ContactNo;
            this.Status = Status;
        }
    }
}