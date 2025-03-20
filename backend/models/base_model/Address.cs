using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.backend.models.base_model {
    public class Address {
        public string Id { get; set; }
        public string SubdivisionName { get; set; }
        public int BlockNumber { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }

        public Address(
                    string Street,
                    int HouseNumber,
                    string SubdivisionName,
                    int BlockNumber = 0) {
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.SubdivisionName = SubdivisionName;
            this.BlockNumber = BlockNumber;
            Id = Guid.NewGuid().ToString();
        }

    }
}