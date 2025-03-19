using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_models;

namespace BMS.backend.models.admin_model {
    public class AdminUser : User {
        public AdminUser(string username, string password, string email)
        : base(username, password, email, Role.Admin) {
        }
    }
}