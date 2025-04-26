using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.models.base_model;

namespace BrgyMs.backend.models.admin_model {

    //So this is another type of user, this is the admin who has a control to all. 
    public class AdminUser : User {
        public string Id = Guid.NewGuid().ToString();
        public AdminUser(string email, string Username, string password, string role = "admin", bool Status = true)
        : base(email,Username, password, role, Status) {
        }
    }
}