using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrgyMs.backend.models.residents_docs {
    public class ResidentDocumentRequest {
        public string Id = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public string DocumentType { get; set; }
        public string Status { get; set; }
        public string Purpose { get; set; }
        public bool isFirstTImeJbSeeker { get; set; }
        public string OtherPurposes { get; set; }

        public ResidentDocumentRequest(
        string Status = "pending",
        string OtherPurposes = "") {
            this.DocumentType = DocumentType;// This is the documents that the resident is requesting. ex. Brgy Clearance. 
            this.Status = Status;
            this.UserId = UserId;
            this.Purpose = Purpose;
            this.OtherPurposes = OtherPurposes;
        }
    }
}