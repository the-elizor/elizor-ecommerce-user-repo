using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.entities.configuration
{
    public class LoginConfiguration
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Scope { get; set; }
        public string Url { get; set; }
        public string AdClientId { get; set; }
        public string AdScope { get; set; }

    }
}
