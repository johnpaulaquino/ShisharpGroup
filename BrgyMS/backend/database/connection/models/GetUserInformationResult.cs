using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrgyMS.backend.database.connection.models {
  
    public class GetUserInformationResult {
        public string Id { get; set; } 
        public string Email { get; set; }
        public string Role { get; set; }
        public string Firstname { get; set; }
        public string Middelanme { get; set; }
        public string Lastname { get; set; }
        public string Suffix { get; set; }
        public string Gender { get; set; }
        public string ResidentType { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string ContactNo { get; set; }
    }
}
