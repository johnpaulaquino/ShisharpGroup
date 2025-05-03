using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BrgyMs.backend.models.bo_model {
    public class ElectionHistories {
        public DateTime TermStart { get; set; }
        public DateTime TermEnd { get; set; }
        public List<string> Accomplished { get; set; }
        public List<string> Achievements { get; set; }
    }
}