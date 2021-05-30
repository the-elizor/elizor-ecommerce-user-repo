// <copyright file="LoginController.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.contracts.Common;
using elizor.ecommerce.user.contracts.Managers;
using elizor.ecommerce.user.entities.authenticate;
using elizor.ecommerce.user.shared.Common;
using elizor.ecommerce.user.shared.Contracts;
using elizor.ecommerce.user.shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.api.Controllers
{
    [Route("")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// The login manager
        /// </summary>
        private readonly ILoginManager _loginManager;

        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<ResponseMessage, ResponseBase> _serviceResponseErrorMapper;

        /// <summary>
        /// ILogger for error logs
        /// </summary>
        private readonly ILogger<LoginController> _logger;

        /// <summary>
        /// The error messages
        /// </summary>
        private readonly IErrorMessages _errorMessages;

        public LoginController(ILoginManager loginManager,
                               IMapper<ResponseMessage, ResponseBase> serviceResponseErrorMapper,
                               ILogger<LoginController> logger,
                               IErrorMessages errorMessages)
        {
            _loginManager = loginManager;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _logger = logger;
            _errorMessages = errorMessages;
        }

        [HttpPost("authenticate")]
        public async Task<ResponseBase> AuthenticateAsync([FromBody] AuthenticateRequest request)
        {
            try
            {
                if (request.Action == RequestActions.Login)
                {
                    return await _loginManager.BasicAthenticationLogin(request);
                }
                return _serviceResponseErrorMapper.Map(new ResponseMessage { Code = "400", Message = "Not Found" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return _serviceResponseErrorMapper.Map(_errorMessages.GetMessageServerError());
            }
        }
    }
}