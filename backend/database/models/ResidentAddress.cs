using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.database.models
{
    public class ResidentAddress
    {
        private string  id = Guid.NewGuid().ToString();
        public string residentId; 
    }
}