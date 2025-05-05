using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BrgyMs.backend.models.bo_model {
    public class ElectionHistories {
        public string Id = Guid.NewGuid().ToString();
        public string TermStart { get; set; }
        public string TermEnd { get; set; }
        public List<string> Accomplished { get; set; }
        public List<string> Achievements { get; set; }
    }
}