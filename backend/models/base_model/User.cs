using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrgyMs.backend.models.base_model {
    // So this is another type of user, who has a limited access in the system.
    // Basically this is a resident
    public class User {

        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }

        public User(string email, string password, string role = "users", bool Status = false) {
            this.Role = role;
            this.Email = email;
            this.Password = password;
            this.Status = Status;
        }
    }
}