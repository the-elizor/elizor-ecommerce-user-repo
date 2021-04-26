using elizor.ecommerce.user.contracts.Managers;
using elizor.ecommerce.user.contracts.Repositories;
using elizor.ecommerce.user.entities.authenticate;
using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.business.Managers
{
    public class LoginManager : ILoginManager
    {
        private readonly ILoginRepository _loginRepository;
        public LoginManager(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;

        }

        public async Task<ResponseBase> LoginUser(AuthenticateRequest request)
        {
            try
            {
                _loginRepository.SaveMyGuest(new entities.test.MyGuest {Email ="test", Firstname = "f", Lastname = "l" });
                return new ResponseBase {IsSuccess = true };
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
