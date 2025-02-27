using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;

namespace BMS.backend.models.admin_model
{
    public class AdminUser : User
    {
        public AdminUser(string email, string password, string role = "admin", bool Status = true)
        : base(email, password, role, Status)
        {
        }
    }
}