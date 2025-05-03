using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BrgyMs.backend.models.bo_model {
    public class OfficialsInfo {
        public string Id = Guid.NewGuid().ToString();
        public DateTime TermStart { get; set; }
        public DateTime TermEnd { get; set; }
        public string Position { get; set; }
        public ElectionHistories ElectionHistories { get; set; } // This is an object that can be seen int the bo_model, 
        // but we will parse this to make a json format using Newtonsoft.Json and store in the db as json format.
        public string Status { get; set; }
        public string UserId { get; set; }


        public OfficialsInfo(

        string Status = "Active") {
            this.Status = Status; // Active, Former, Resigned, Removed, Decease
        }
    }
}