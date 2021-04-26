using elizor.ecommerce.user.contracts.Managers;
using elizor.ecommerce.user.entities.authenticate;
using elizor.ecommerce.user.shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.api.Controllers
{
    [Route("")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginManager _loginManager;

        public LoginController(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        [HttpPost("Authenticate")]
        public async Task<ResponseBase> AuthenticateAsync([FromBody] AuthenticateRequest request)
        {
            try
            {
                return await _loginManager.LoginUser(request);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}