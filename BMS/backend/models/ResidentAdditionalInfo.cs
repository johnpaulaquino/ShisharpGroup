using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.database.models {
    public enum MaritalStatus {
        Widowed, Single, Married
    }
    public enum EmploymentStatus {
        Employed, Unemployed, SelfEmployed, Retired
    }
    public enum EducationalAttainment {
        None, Elementary, HighSchool, College, Postgraduate
    }
    public class ResidentAdditionalInfo(string userId,
                                    byte[] profileImage,
                                    string occupation,
                                    int annualSalary,
                                    EmploymentStatus empStatus,
                                    EducationalAttainment educAttain,
                                    MaritalStatus maritalStatus,
                                    bool isVoter = false) {
        public string id = Guid.NewGuid().ToString();
        public string userId { get; set; } = userId;
        public byte[] profileImage { get; set; } = profileImage;
        public string occupation { get; set; } = occupation;
        public int annualSalary { get; set; } = annualSalary;
        public bool isVoter { get; set; } = isVoter;
        public MaritalStatus maritalStatus { get; set; } = maritalStatus;
        public EmploymentStatus empStatus { get; set; } = empStatus;
        public EducationalAttainment educAttain { get; set; } = educAttain;

        public void setCivilStatus(string maritalStatus) {
            switch (maritalStatus) {
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
            }
        }
    }
}