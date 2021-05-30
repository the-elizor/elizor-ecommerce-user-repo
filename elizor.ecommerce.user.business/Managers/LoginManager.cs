// <copyright file="LoginManager.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.contracts.Hanlders;
using elizor.ecommerce.user.contracts.Managers;
using elizor.ecommerce.user.contracts.Repositories;
using elizor.ecommerce.user.entities.authenticate;
using elizor.ecommerce.user.entities.configuration;
using elizor.ecommerce.user.entities.discoverDocument;
using elizor.ecommerce.user.shared.Models;
using IdentityModel.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.business.Managers
{
    public class LoginManager : ILoginManager
    {
        /// <summary>
        /// ILogger for error logs
        /// </summary>
        private readonly ITokenHandler _tokenHandler;

        /// <summary>
        /// The configs
        /// </summary>
        private readonly LoginConfiguration _loginConfiguration;

        /// <summary>
        /// ILogger for error logs
        /// </summary>
        private readonly ILogger<LoginManager> _logger;


        public LoginManager(ITokenHandler tokenHandler, IOptions<LoginConfiguration> loginOptions, ILogger<LoginManager> logger)
        {
            _tokenHandler = tokenHandler;
            _loginConfiguration = loginOptions?.Value;
            _logger = logger;
        }

        public async Task<ResponseBase> BasicAthenticationLogin(AuthenticateRequest request)
        {
            try
            {
                var disco = await _tokenHandler.GetDiscoveryDocumentAsync(_loginConfiguration.Url).ConfigureAwait(false);

                if (disco.IsError)
                {
                    return new ResponseBase
                    {
                        IsSuccess = false,
                        Result = null,
                        Error = new ResponseMessage { Message = disco.Exception.Message, Code = disco.Error },
                    };
                }

                if (String.IsNullOrEmpty(request.Attributes.Username)
                      || String.IsNullOrWhiteSpace(request.Attributes.Username))
                {
                    return new ResponseBase
                    {
                        IsSuccess = false,
                        Result = null,
                        Error = new ResponseMessage
                        {
                            Message = "User Doesn't Exist",
                            Code = "User"
                        },
                    };
                }

                IdentityTokenResponse tokenResponse;

                using (PasswordTokenRequest passwordTokenRequestnew = new PasswordTokenRequest())
                {
                    passwordTokenRequestnew.UserName = request.Attributes.Username;
                    passwordTokenRequestnew.Password = request.Attributes.Password;
                    passwordTokenRequestnew.Address = disco.TokenEndpoint;
                    passwordTokenRequestnew.ClientId = _loginConfiguration.ClientId;
                    passwordTokenRequestnew.ClientSecret = _loginConfiguration.ClientSecret;
                    passwordTokenRequestnew.Scope = _loginConfiguration.Scope;
                    passwordTokenRequestnew.Parameters = new Parameters(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("client", request.ClientId) });

                    tokenResponse = await _tokenHandler.RequestPasswordTokenAsync(passwordTokenRequestnew).ConfigureAwait(false);
                }

                if (!tokenResponse.IsError)
                {
                    return new ResponseBase
                    {
                        IsSuccess = true,
                        Result = new AuthenticateResult
                        {
                            Username = request.Attributes.Username,
                            AccessToken = tokenResponse.AccessToken,
                            RefreshToken = tokenResponse.RefreshToken

                        }
                    };
                }
                else
                {
                    Console.WriteLine(tokenResponse.Error);
                    return new ResponseBase
                    {
                        IsSuccess = false,
                        Error = new ResponseMessage { Message = "Invalid User", Code = "Invalid User" },
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }
    }
}
