using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BrgyMs.backend.models.bo_model {
    public class OfficialsInfo {
        public DateTime TermStart { get; set; }
        public DateTime TermEnd { get; set; }
        public string Position { get; set; }
        public string ElectionHistories { get; set; } // This is an object that can be seen int the bo_model, 
        // but we will parse this to make a json format using Newtonsoft.Json and store in the db as json format.
        public string Status { get; set; }


        public OfficialsInfo(
        DateTime TermStart,
        DateTime TermEnd,
        string Position,
        string ElectionHistories,
        string Status = "active") {


            this.TermStart = TermStart;
            this.TermEnd = TermEnd;
            this.Position = Position;
            this.ElectionHistories = ElectionHistories;
            this.Status = Status; // Active, Former, Resigned, Removed, Decease
        }
    }
}