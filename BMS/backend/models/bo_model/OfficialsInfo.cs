using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.bo_model
{
    public class OfficialsInfo
    {
        public DateTime TermStart { get; set; }
        public DateTime TermEnd { get; set; }
        public string Position { get; set; }
        public string ElectionHistories { get; set; }


        public OfficialsInfo(DateTime TermStart, DateTime TermEnd, string Position, string ElectionHistories)
        {
            this.TermStart = TermStart;
            this.TermEnd = TermEnd;
            this.Position = Position;
            this.ElectionHistories = ElectionHistories;
        }
    }
}