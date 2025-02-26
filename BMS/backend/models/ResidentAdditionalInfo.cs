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
        public byte[] profileImage { get; set; }
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
                                        byte[] profileImage = null) {
            this.profileImage = profileImage;
            this.birthDate = birthDate;
            this.isVoter = isVoter;
            age = utils.calculateAge(this.birthDate);
            SetEmploymentStatus(empStatus);
            SetMartialStatus(maritalStatus);
            SetEducationalAttain(educAttain);

        }

        private void SetEmploymentStatus(string empStatus) {
            //this.empStatus = empStatus switch {
            //    "Employed" => EmploymentStatus.Employed,
            //    "UnEmployed" => EmploymentStatus.Unemployed,
            //    "SelfEmployed" => EmploymentStatus.SelfEmployed,
            //    "Retired" => EmploymentStatus.Retired,
            //    _ => throw new Exception("Invalid Choice"),
            //}
            switch (empStatus)
            {
                case "Employed":
                    this.empStatus = EmploymentStatus.Employed;
                    break;
                case "UnEmployed":
                    this.empStatus = EmploymentStatus.Unemployed;
                    break;
                case "SelfEmployed":
                    this.empStatus = EmploymentStatus.SelfEmployed;
                    break;
                case "Retired":
                    this.empStatus = EmploymentStatus.Retired;
                    break;
                default:
                    throw new Exception("Invalid Choice");

            }
           


        }
        private void SetMartialStatus(string maritalStatus) {
            //this.maritalStatus = maritalStatus switch {
            //    "Single" => MaritalStatus.Single,
            //    "Married" => MaritalStatus.Married,
            //    "Widowed" => MaritalStatus.Widowed,
            //    _ => throw new Exception("Invalid Choice"),
            //};
            switch (maritalStatus)
            {
                case "Single":
                    this.maritalStatus = MaritalStatus.Single;
                    break;
                case "Married":
                    this.maritalStatus = MaritalStatus.Married;
                    break;
                case "Widowed":
                    this.maritalStatus = MaritalStatus.Widowed;
                    break;
                default:
                    throw new Exception("Invalid Choice");
                    break;

            }
        }
        private void SetEducationalAttain(string educAttain) {
            //this.educAttain = educAttain switch {
            //    "Elementary" => EducationalAttainment.Elementary,
            //    "HighSchool" => EducationalAttainment.HighSchool,
            //    "College" => EducationalAttainment.College,
            //    "Postgraduate" => EducationalAttainment.Postgraduate,
            //    "None" => EducationalAttainment.None,
            //    _ => throw new Exception("Invalid Choice"),

            switch (educAttain)
            {
                case "Elementary":
                    this.educAttain = EducationalAttainment.Elementary;
                    break;
                case "HighSchool":
                    this.educAttain = EducationalAttainment.HighSchool;
                    break;
                case "College":
                    this.educAttain = EducationalAttainment.College;
                    break;
                case "Postgraduate":
                    this.educAttain = EducationalAttainment.Postgraduate;
                    break;
                case "None":
                    this.educAttain = EducationalAttainment.None;
                    break;
                default:
                    throw new Exception("Invalid Choice");

            }

        }
    }
}