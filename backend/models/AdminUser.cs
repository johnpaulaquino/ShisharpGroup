using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.models {
    public class AdminUser(string username, string email, string password) :
    User(username, email, password, Role.Admin) {
    }
}