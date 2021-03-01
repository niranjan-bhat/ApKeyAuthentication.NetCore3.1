using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApKeyAuthentication
{
    public class ApiKey
    {
        public string ApiKeyValue { get; set; }
        public DateTime IssuedOn { get; set; }
        public IList<Roles> AssignedRoles { get; set; }
    }
}
