using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.base_model {
    public class Address {
        public string id { get; set; }
        public string subdivisionName { get; set; }
        public int blockNumber { get; set; }
        public string street { get; set; }
        public int houseNumber { get; set; }

        public Address(
                    string street,
                    int houseNumber,
                    string subdivisionName,
                    int blockNumber = 0) {
            this.street = street;
            this.houseNumber = houseNumber;
            this.subdivisionName = subdivisionName;
            this.blockNumber = blockNumber;
            id = Guid.NewGuid().ToString();
        }

    }
}