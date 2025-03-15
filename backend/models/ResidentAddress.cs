using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.database.models {
    public class ResidentAddress {
        private string id = Guid.NewGuid().ToString();
        public string userId;
        public string subdivisionName { get; set; }
        public int blockNumber { get; set; }
        public string street { get; set; }
        public int houseNumber { get; set; }

        public ResidentAddress(string userId,
                                string street,
                                int houseNumber,
                                string subdivisionName,
                                int blockNumber) {
            this.userId = userId;
            this.street = street;
            this.houseNumber = houseNumber;
            this.subdivisionName = subdivisionName;
            this.blockNumber = blockNumber;
        }

    }

}