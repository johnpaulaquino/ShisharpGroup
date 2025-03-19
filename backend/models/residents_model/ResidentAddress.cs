using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;

namespace BMS.backend.models.residents_model {
    public class ResidentAddress : Address {
        public ResidentAddress(string street, int houseNumber, string subdivisionName, int blockNumber = 0) :
        base(street, houseNumber, subdivisionName, blockNumber) {
        }
    }

}