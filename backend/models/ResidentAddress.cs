using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.database.models {
    public class ResidentAddress(string userId,
                            string street,
                            int houseNumber,
                            string subdivisionName,
                            int blockNumber) {
        private string id = Guid.NewGuid().ToString();
        public string userId = userId;
        public string subdivisionName { get; set; } = subdivisionName;
        public int blockNumber { get; set; } = blockNumber;
        public string street { get; set; } = street;
        public int houseNumber { get; set; } = houseNumber;
    }

}