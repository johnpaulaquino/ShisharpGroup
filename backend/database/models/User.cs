using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.database.models
{
    public class User
    {
            private String id ;
            private String fName;
            private String lName;
            private String email;
            private String password;
        
        public User(
            String id,
            String fName, 
            String lName, 
            String email, 
            String password){
        
        this.id = id;
        this.fName = fName;
        this.lName = lName;
        this.email = email;
        this.password = password;
        }
   public override string ToString()
    {
        return $"User Information\nid: {this.id}\nFirstname: {this.fName}";
    }
    
    }
}