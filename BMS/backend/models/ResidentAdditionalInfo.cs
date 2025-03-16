using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.utils;
using Microsoft.VisualBasic;

namespace BMS.backend.database.models {
    public enum MaritalStatus {
        Widowed, Single, Married
    }
    public enum EmploymentStatus {
        Employed, Unemployed, SelfEmployed, Retired
    }
    public enum EducationalAttainment {
        None, Elementary, HighSchool, College, Postgraduate
    }
    public class ResidentAdditionalInfo {
        public Utils utils = new Utils();
        public string id = Guid.NewGuid().ToString();
        public byte[]? profileImage { get; set; }
        public bool isVoter { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public EmploymentStatus empStatus { get; set; }
        public EducationalAttainment educAttain { get; set; }
        public DateTime birthDate;
        public int age { get; }

        public ResidentAdditionalInfo(
                                        bool isVoter,
                                        DateTime birthDate,
                                        string empStatus,
                                        string educAttain,
                                        string maritalStatus,
                                        byte[]? profileImage = null) {
            this.profileImage = profileImage;
            this.birthDate = birthDate;
            this.isVoter = isVoter;
            age = utils.calculateAge(this.birthDate);
            SetEmploymentStatus(empStatus);
            SetMartialStatus(maritalStatus);
            SetEducationalAttain(educAttain);

        }

        private void SetEmploymentStatus(string empStatus) {
            this.empStatus = empStatus switch {
                "Employed" => EmploymentStatus.Employed,
                "UnEmployed" => EmploymentStatus.Unemployed,
                "SelfEmployed" => EmploymentStatus.SelfEmployed,
                "Retired" => EmploymentStatus.Retired,
                _ => throw new Exception("Invalid Choice"),
            };
        }
        private void SetMartialStatus(string maritalStatus) {
            this.maritalStatus = maritalStatus switch {
                "Single" => MaritalStatus.Single,
                "Married" => MaritalStatus.Married,
                "Widowed" => MaritalStatus.Widowed,
                _ => throw new Exception("Invalid Choice"),
            };
        }
        private void SetEducationalAttain(string educAttain) {
            this.educAttain = educAttain switch {
                "Elementary" => EducationalAttainment.Elementary,
                "HighSchool" => EducationalAttainment.HighSchool,
                "College" => EducationalAttainment.College,
                "Postgraduate" => EducationalAttainment.Postgraduate,
                "None" => EducationalAttainment.None,
                _ => throw new Exception("Invalid Choice"),
            };
        }
    }
}