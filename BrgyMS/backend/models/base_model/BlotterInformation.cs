using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrgyMS.backend.models.base_model {
    public class BlotterInformation {
        public string Id = Guid.NewGuid().ToString();
        public string ComplainantId { get; set; }
        public string RespondentId { get; set; }
        public string Statements { get; set; }
        public string Status { get; set; } //Unsettled, Settled, Dismissed
        public DateTime DateFiled { get; set; }

        public BlotterInformation(string Status = "unsettled") {
            this.Status = Status;
        }
    }
}
