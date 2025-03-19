using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;
using BMS.backend.utils;

namespace BMS.backend.models.residents_model {

    public class ResidentInfo : PersonalInformation {
        public ResidentInfo(string email, string firstname, string middlename, string lastname, string gender, string category)
        : base(email, firstname, middlename, lastname, gender, category) {
        }
    }
}