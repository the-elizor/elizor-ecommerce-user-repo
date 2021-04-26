using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.entities.authenticate
{
    public class AuthenticateRequest : RequestBase
    {
        public string Action { get; set; }

        public AuthenticationRequestAttributes Attributes { get; set; }
    }
}
