using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;
using BMS.backend.utils;


namespace BMS.backend.models.residents_model {

    public class ResidentAdditionalInfo : AdditionalInfo {
        public ResidentAdditionalInfo(bool isVoter, DateTime birthDate, string empStatus, string educAttain, string maritalStatus, string contactNo, string status = "Active", int[] profileImage = null)
        : base(isVoter, birthDate, empStatus, educAttain, maritalStatus, contactNo, status, profileImage) {
        }
    }
}