using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.models {
    public enum Role {
        IT, Admin, Resident
    }
    public class User(string username, string email, string password, Role role = Role.Resident) {
        public string id = Guid.NewGuid().ToString();
        public string username { get; set; } = username;
        public string password { get; set; } = password;
        public string email { get; set; } = email;
        public Role role { get; set; } = role;
    }
}