using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.bo_model {
    public class OfficialsInfo {
        public DateOnly TermStart { get; set; }
        public DateOnly TermEnd { get; set; }
        public string position { get; set; }


        public OfficialsInfo(DateOnly TermStart, DateOnly TermEnd, string position) {
            this.TermStart = TermStart;
            this.TermEnd = TermEnd;
            this.position = position;
        }
    }
}