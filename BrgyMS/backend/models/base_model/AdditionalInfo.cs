using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.utils;

namespace BrgyMs.backend.models.base_model
{
    public class AdditionalInfo
    {

        public Utils utils = new Utils();
        public string Id = Guid.NewGuid().ToString();
        public byte[] ProfileImage { get; set; }
        public bool IsVoter { get; set; }
        public string CivilStatus { get; set; } // Single, Widowed, Married, and Divorce
        public string EmpStatus { get; set; } // Employee, Self-employed, Unemployed, Volunteer
        public string EducAttain { get; set; } // Elementary, Junior High School, Senior High School, College, Masteral, Docotrate, and None
        public DateTime BirthDate;
        public string ContactNo { get; set; }
        public string Status { get; set; } // enable and disabled
        public string Religion { get; set; }
        public byte[] ProofOfResidency { get; set; }
        public AdditionalInfo(
                            bool IsVoter,
                            DateTime BirthDate,
                            string EmpStatus,
                            string EducAttain,
                            string CivilStatus,
                            string ContactNo,
                             string Religion,
                             byte[] ProofOfResidency,
        string Status = "disabled",
        byte[] ProfileImage = null)
        { 

            this.ProfileImage = ProfileImage;
            this.Religion = Religion;
            this.BirthDate = BirthDate;
            this.IsVoter = IsVoter;
            this.EducAttain = EducAttain;
            this.CivilStatus = CivilStatus;
            this.EmpStatus = EmpStatus;
            this.ContactNo = ContactNo;
            this.Status = Status;
        }
    }
}