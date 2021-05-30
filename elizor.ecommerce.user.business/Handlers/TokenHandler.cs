using elizor.ecommerce.user.contracts.Hanlders;
using elizor.ecommerce.user.entities.configuration;
using elizor.ecommerce.user.entities.discoverDocument;
using elizor.ecommerce.user.shared.Models;
using IdentityModel.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.business.Handlers
{
    public class TokenHandler : ITokenHandler
    {
        /// <summary>
        /// ILogger for error logs
        /// </summary>
        private readonly ILogger<TokenHandler> _logger;

        /// <summary>
        /// The configs
        /// </summary>
        //private readonly LoginConfiguration _loginConfiguration;

        public TokenHandler(ILogger<TokenHandler> logger)
        {
            _logger = logger;
            //_loginConfiguration = loginOptions?.Value;
        }

        //Task<ResponseBase> ITokenHandler.GetAccessToken(string request, string authanticationType)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IdentityDiscoveryDocumentResponse> GetDiscoveryDocumentAsync(string address)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var disco = await client.GetDiscoveryDocumentAsync(address).ConfigureAwait(false);
                    return new IdentityDiscoveryDocumentResponse()
                    {
                        IsError = disco.IsError,
                        AuthorizeEndpoint = disco.AuthorizeEndpoint,
                        CheckSessionIframe = disco.CheckSessionIframe,
                        ClaimsSupported = disco.ClaimsSupported,
                        DeviceAuthorizationEndpoint = disco.DeviceAuthorizationEndpoint,
                        EndSessionEndpoint = disco.EndSessionEndpoint,
                        IntrospectionEndpoint = disco.IntrospectionEndpoint,
                        Issuer = disco.Issuer,
                        JwksUri = disco.JwksUri,
                        KeySet = disco.KeySet,
                        Policy = disco.Policy,
                        RegistrationEndpoint = disco.RegistrationEndpoint,
                        RevocationEndpoint = disco.RevocationEndpoint,
                        TokenEndpoint = disco.TokenEndpoint,
                        TokenEndpointAuthenticationMethodsSupported = disco.TokenEndpointAuthenticationMethodsSupported,
                        UserInfoEndpoint = disco.UserInfoEndpoint,
                        Error = disco.Error,
                        Exception = disco.Exception
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        public async Task<IdentityTokenResponse> RequestPasswordTokenAsync(PasswordTokenRequest tokenRequest)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var token = await client.RequestPasswordTokenAsync(tokenRequest).ConfigureAwait(false);
                    return new IdentityTokenResponse()
                    {
                        IsError = token.IsError,
                        AccessToken = token.AccessToken,
                        ErrorDescription = token.ErrorDescription,
                        ExpiresIn = token.ExpiresIn,
                        IdentityToken = token.IdentityToken,
                        IssuedTokenType = token.IssuedTokenType,
                        RefreshToken = token.RefreshToken,
                        Scope = token.Scope,
                        TokenType = token.TokenType,
                        Error = token.Error,
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
