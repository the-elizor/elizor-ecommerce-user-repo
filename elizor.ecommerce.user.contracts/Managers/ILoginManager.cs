using elizor.ecommerce.user.entities.authenticate;
using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.contracts.Managers
{
    public interface ILoginManager
    {
        Task<ResponseBase> LoginUser(AuthenticateRequest request);
    }
}
