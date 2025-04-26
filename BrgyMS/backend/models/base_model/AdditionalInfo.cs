using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrgyMs.backend.models.base_model {
    public class AdditionalInfo {

        public Utils utils = new Utils();
        public string Id = Guid.NewGuid().ToString();
        public byte[] ProfileImage { get; set; }
        public bool IsVoter { get; set; }
        public string CivilStatus { get; set; } // Single, Widowed, Married, and Divorce
        public string EmpStatus { get; set; } // Employee, Self-employed, Unemployed, Volunteer
        public string EducAttain { get; set; } // Elementary, Junior High School, Senior High School, College, Masteral, Docotrate, and None
        public string ResidentType { get; set; }
        public int Age { get; set; }

        public DateTime BirthDate;
        public string ContactNo { get; set; }
        public string Religion { get; set; }
        public byte[] ProofOfResidency { get; set; }
        public AdditionalInfo(
                            bool IsVoter,
                            DateTime BirthDate,
                            string EmpStatus,
                            string EducAttain,
                            string CivilStatus,
                             string ResidentType,
                            string ContactNo,
                             string Religion,
                             byte[] ProofOfResidency,
        byte[] ProfileImage = null, int Age = 0) {

            this.ProofOfResidency = ProofOfResidency;
            this.Age = Age;
            this.ProfileImage = ProfileImage;
            this.Religion = Religion;
            this.BirthDate = BirthDate;
            this.IsVoter = IsVoter;
            this.EducAttain = EducAttain;
            this.CivilStatus = CivilStatus;
            this.EmpStatus = EmpStatus;
            this.ContactNo = ContactNo;
            this.ResidentType = ResidentType;

        }
    }
}