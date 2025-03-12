using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.database.models
{
    public enum MaritalStatus{
        Widowed,Single,Married
    }
    public enum EmploymentStatus{
        Employed, Unemployed, SelfEmployed, Retired
    }
    public enum EducationalAttainment{
        None, Elementary, HighSchool, College, Postgraduate
    }
    public class ResidentAdditionalInfo
    {
        public string id = Guid.NewGuid().ToString();
        public string residentId;
        public  byte []  profileImage{ get; set; }
        public string occupation {get; set;}
        public int annualSalary {get; set;}
        public bool isVoter { get; set; }  
        public MaritalStatus maritalStatus{get; set;}
        public  EmploymentStatus empStatus{get;set;}
        public EducationalAttainment educAttain{get;set;} 
    
    public ResidentAdditionalInfo(  string residentId,
                                    byte [] profileImage, 
                                    string occupation,
                                    int annualSalary,
                                    MaritalStatus maritalStatus,
                                    bool isVoter = false){
    this.residentId = residentId;
    this.profileImage = profileImage;
    this.occupation = occupation;
    this.annualSalary = annualSalary;
    this.maritalStatus = maritalStatus;

    }

    public void setCivilStatus(string maritalStatus){
        switch(maritalStatus){
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