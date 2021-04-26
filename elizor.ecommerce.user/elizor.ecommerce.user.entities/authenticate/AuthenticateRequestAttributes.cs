using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.entities.authenticate
{
    public class AuthenticationRequestAttributes
    {
        public string PhoneNumber { get; set; }
        public string CorrelationId { get; set; }
        public string Otp { get; set; }
        public string CountryId { get; set; }
    }
}
