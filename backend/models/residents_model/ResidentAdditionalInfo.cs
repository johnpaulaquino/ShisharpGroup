using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;
using BMS.backend.utils;


namespace BMS.backend.models.residents_model {

    public class ResidentAdditionalInfo : AdditionalInfo {
        public byte[] ProofOfResidency { get; set; }
        public ResidentAdditionalInfo(bool IsVoter,
        DateTime BirthDate,
        string EmpStatus,
        string EducAttain,
        string MaritalStatus,
        string ContactNo,
        string Status = "disabled",
        int[] ProfileImage = null,
        byte[] ProofOfResidency = null)
        : base(IsVoter, BirthDate, EmpStatus, EducAttain, MaritalStatus, ContactNo, Status, ProfileImage) {
            this.ProofOfResidency = ProofOfResidency;
        }
    }
}