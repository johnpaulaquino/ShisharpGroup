using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrgyMS.backend.models {
    public class AnnouncementsModel {
        public string Id = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
        public DateTime DatePost { get; set; }
        public String PostBy { get; set; }
        public byte[] Attachments { get; set; }



        public AnnouncementsModel(bool Status = true) {
            this.Status = Status;
        }
    }
}
