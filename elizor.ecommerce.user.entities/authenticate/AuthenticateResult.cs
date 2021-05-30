using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.entities.authenticate
{
    public class AuthenticateResult
    {
        public string Username { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
