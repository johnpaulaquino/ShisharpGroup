using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;

namespace BMS.backend.models.secretary_model {


    //This is a another user, who handles the resident info. we can compare it in a manager.
    public class SecretaryUser : User {
        public string Id = Guid.NewGuid().ToString();
        public SecretaryUser(string Email, string Password, string Role = "secretary", bool Status = true) : base(Email, Password, Role, Status) {

        }
    }
}