using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models
{
    public class AdminUser : User
    {
        public AdminUser(string username, string password, string email)
        : base(username, password, email, Role.Admin) {
        }
    }
}