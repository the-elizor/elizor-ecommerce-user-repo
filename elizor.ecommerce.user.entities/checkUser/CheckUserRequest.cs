using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.entities.checkUser
{
    public class CheckUserRequest : RequestBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
