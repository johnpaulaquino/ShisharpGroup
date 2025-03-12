using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpBackEnd.backend.utils;

namespace CSharpBackEnd.backend.database.models
{

    public enum Gender{
    Male,
    Female,
    Others 
    }

    public class ResidentInfo
    {
       public string id = Guid.NewGuid().ToString();
       public string userId{get;set;}
       public string firstname{get;set;}
       public string middlename{get;set;}
       public string lastName{get;set;}
       public DateTime birthDate;
       public Gender gender{get;set;}


    public ResidentInfo(string userId, 
    string firstname, 
    string lastname, 
    string middlename,
    string email,
    DateTime birthDate, 
    Gender gender){

        this.userId = userId;
        this.firstname = firstname;
        this.middlename = middlename;
        this.lastName = lastname;   
        this.birthDate = birthDate;
        this.gender = gender;

    }

    public void setBirthday(DateTime birthDate){
        this.birthDate = birthDate;
    }
    public void setGender(string genderString){
        switch(genderString){
            case "Male":
            this.gender = Gender.Male;
            break;
            
            case "Female":
            this.gender = Gender.Female;
            break;

            case "Others":
            this.gender = Gender.Others;
            break;

            default:
            throw new Exception("Invalid selection!");
        }
    }

    public string getId(){
        return this.id;
    }

     public String getBirthday(){
        
        string formatted = this.birthDate.ToString("yyyy-MM-dd");
        
        return formatted;
    }

    public override string ToString(){
        return $"id: {this.id}\nGender: {this.gender}";
    }
  
}
}