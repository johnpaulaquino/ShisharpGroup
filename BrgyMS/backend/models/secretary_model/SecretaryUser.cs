using BrgyMs.backend.models.base_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrgyMs.backend.models.secretary_model
{
    public class SecretaryUser : User
    {
        public string Id = Guid.NewGuid().ToString();
        public SecretaryUser(string Email, string Password, string Role = "secretary", bool Status = true) : base(Email, Password, Role, Status)
        {

        }
    }
}
