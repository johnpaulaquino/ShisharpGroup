using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.residents_model
{
    public class ResidentDocumentRequest
    {
        public string Id = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public string DocumentType { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public ResidentDocumentRequest(string UserId,
        string DocumentType,
        string Description,
        string Status = "pending")
        {
            this.DocumentType = DocumentType;
            this.Status = Status;
            this.UserId = UserId;
            this.Description = Description;
        }
    }
}