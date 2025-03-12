using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.models
{
    public enum Role{
        IT, Admin, Resident
    }
    public class User
    {
        public string id = Guid.NewGuid().ToString();
        public string username{get; set;}
        public string password{get; set;}
        public string email{get; set;}
        public Role role{get; set;}

        public User(string username, string password, string email, Role role = Role.Resident){
            this.role = role;
            this.username = username;
            this.email = email;
            this.password = password;
        }
    }
}