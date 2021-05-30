using elizor.ecommerce.user.contracts.Common;
using elizor.ecommerce.user.contracts.Managers;
using elizor.ecommerce.user.contracts.Repositories;
using elizor.ecommerce.user.entities.checkUser;
using elizor.ecommerce.user.shared.Contracts;
using elizor.ecommerce.user.shared.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.business.Managers
{
    public class UserSecurityManager : IUserSecurityManager
    {
        /// <summary>
        /// The Login repository
        /// </summary>
        private readonly ILoginRepository _loginRepository;

        /// <summary>
        /// ILogger for error logs
        /// </summary>
        private readonly ILogger<UserSecurityManager> _logger;

        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<ResponseMessage, ResponseBase> _serviceResponseErrorMapper;

        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<Object, ResponseBase> _serviceResponseMapper;

        /// <summary>
        /// The error messages
        /// </summary>
        private readonly IErrorMessages _errorMessages;

        public UserSecurityManager(ILoginRepository loginRepository,
                                   ILogger<UserSecurityManager> logger,
                                   IMapper<ResponseMessage, ResponseBase> serviceResponseErrorMapper,
                                   IMapper<Object, ResponseBase> serviceResponseMapper,
                                   IErrorMessages errorMessages)
        {
            _loginRepository = loginRepository;
            _logger = logger;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _serviceResponseMapper = serviceResponseMapper;
            _errorMessages = errorMessages;
        }

        public ResponseBase CheckUserExists(CheckUserRequest request)
        {
            try
            {
                CheckUserResponse userResponse = _loginRepository.CheckUserExists(request);

                return userResponse
                       != null ? _serviceResponseMapper.Map(userResponse) : _serviceResponseErrorMapper.Map(_errorMessages.GetMessageUserNotFoundError());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }
    }
}
