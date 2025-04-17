using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrgyMs.backend.models.base_model
{
    public class Address
    {
        public string Id = Guid.NewGuid().ToString();
        public string SubdivisionName { get; set; }
        public string BlockNumber { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Purok { get; set; }
        public string LotNo { get; set; }


        public Address(
                    string Street,
                    string HouseNumber,
                    string SubdivisionName = "",
                    string BlockNumber = "",
                    string LotNo = "",
                    string Purok = "")
        {
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.SubdivisionName = SubdivisionName;
            this.BlockNumber = BlockNumber;
            this.Purok = Purok;
            this.LotNo = LotNo;

        }

    }
}