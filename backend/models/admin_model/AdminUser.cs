using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;

namespace BMS.backend.models.admin_model {

    //So this is another type of user, this is the admin who has a control to all. 
    public class AdminUser : User {
        public string Id = Guid.NewGuid().ToString();
        public AdminUser(string email, string password, string role = "admin", bool Status = true)
        : base(email, password, role, Status) {
        }
    }
}