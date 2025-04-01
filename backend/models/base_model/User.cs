using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.base_model {
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