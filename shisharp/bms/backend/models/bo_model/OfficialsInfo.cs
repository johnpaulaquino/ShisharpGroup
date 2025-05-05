using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BrgyMs.backend.models.bo_model {
    public class OfficialsInfo {
        public string Id = Guid.NewGuid().ToString();
        public string Position { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
        public DateTime TermStart { get; set; }
        public DateTime TermEnd { get; set; }


        public OfficialsInfo(

        string Status = "Active") {
            this.Status = Status; // Active, Former, Resigned, Removed, Decease
        }
    }
}