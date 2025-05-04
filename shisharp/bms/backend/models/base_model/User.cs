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
        public string Username { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public string UserId { get; set; }

        public User(string email, string Username, string password ="", string role = "users", bool Status = false, string UserId = "") {
            this.Role = role;
            this.Username = Username;
            this.Email = email;
            this.Password = password;
            this.Status = Status;
            this.UserId = UserId;
        }
    }
}