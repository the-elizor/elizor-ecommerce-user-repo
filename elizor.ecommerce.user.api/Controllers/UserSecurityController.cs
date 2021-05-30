using elizor.ecommerce.user.contracts.Common;
using elizor.ecommerce.user.contracts.Managers;
using elizor.ecommerce.user.entities.checkUser;
using elizor.ecommerce.user.shared.Contracts;
using elizor.ecommerce.user.shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace elizor.ecommerce.user.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UserSecurityController : ControllerBase
    {
        /// <summary>
        /// The user security manager
        /// </summary>
        private readonly IUserSecurityManager _userSecurityManager;

        /// <summary>
        /// ILogger for error logs
        /// </summary>
        private readonly ILogger<UserSecurityController> _logger;

        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<ResponseMessage, ResponseBase> _serviceResponseErrorMapper;

        /// <summary>
        /// The error messages
        /// </summary>
        private readonly IErrorMessages _errorMessages;

        public UserSecurityController(IUserSecurityManager userSecurityManager,
                                      ILogger<UserSecurityController> logger,
                                      IMapper<ResponseMessage, ResponseBase> serviceResponseErrorMapper,
                                      IErrorMessages errorMessages)
        {
            _userSecurityManager = userSecurityManager;
            _logger = logger;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _errorMessages = errorMessages;
        }

        /// <summary>
        /// Checks the user.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [HttpPost("UserExists")]
        public ResponseBase CheckUserExist([FromBody]CheckUserRequest request)
        {
            try
            {
                return _userSecurityManager.CheckUserExists(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return _serviceResponseErrorMapper.Map(_errorMessages.GetMessageServerError());
            }
        }
    }
}
