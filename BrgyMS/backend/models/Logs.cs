using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrgyMS.backend.models {
    public class Logs {

        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime? DatePerformed { get; set; }
        public string ActionsMade { get; set; }
        public string Details { get; set; }

        public Logs(string Id, string UserId,
             string ActionsMade, DateTime? DatePerformed = null,
                string Details = "") {

            this.Id = Id;
            this.UserId = UserId;
            this.DatePerformed = DatePerformed;
            this.ActionsMade = ActionsMade;
            this.Details = Details;

        }
    }
}
