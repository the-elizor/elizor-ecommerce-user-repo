using elizor.ecommerce.user.entities.checkUser;
using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.contracts.Managers
{
    /// <summary>
    /// User securiy manager contract
    /// </summary>
    public interface IUserSecurityManager
    {
        /// <summary>
        /// Checks the user exist.
        /// </summary>
        ResponseBase CheckUserExists(CheckUserRequest request);
    }
}
