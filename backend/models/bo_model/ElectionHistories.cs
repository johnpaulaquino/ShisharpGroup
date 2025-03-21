using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BMS.backend.models.bo_model {
    public class ElectionHistories {
        public DateOnly TermStart { get; set; }
        public DateOnly TermEnd { get; set; }
        public List<string> Accomplished { get; set; }
        public List<string> Achievements { get; set; }

        public ElectionHistories(DateOnly TermStart,
                    DateOnly TermEnd,
                    List<string> Accomplished,
                    List<string> Achievements) {

            this.TermStart = TermStart;
            this.TermEnd = TermEnd;
            this.Accomplished = Accomplished;
            this.Achievements = Achievements;
        }
    }
}