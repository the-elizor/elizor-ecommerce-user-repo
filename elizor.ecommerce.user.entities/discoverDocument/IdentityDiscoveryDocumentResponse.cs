using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityModel.Client;
using IdentityModel.Jwk;

namespace elizor.ecommerce.user.entities.discoverDocument
{
    public class IdentityDiscoveryDocumentResponse
    {
        /// <summary>
        /// Error status.
        /// </summary>
        public bool IsError { get; set; }

        /// <summary>
        /// Token end point 
        /// </summary>
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Authorize end point
        /// </summary>
        public string AuthorizeEndpoint { get; set; }

        /// <summary>
        /// Issuer
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Introspection Endpoint
        /// </summary>
        public string IntrospectionEndpoint { get; set; }

        /// <summary>
        /// Registration Endpoint
        /// </summary>
        public string RegistrationEndpoint { get; set; }

        /// <summary>
        /// Check Session Iframe
        /// </summary>
        public string CheckSessionIframe { get; set; }

        /// <summary>
        /// End Session Endpoint
        /// </summary>
        public string EndSessionEndpoint { get; set; }

        /// <summary>
        /// JwksUri
        /// </summary>
        public string JwksUri { get; set; }

        /// <summary>
        /// Device Authorization Endpoint
        /// </summary>
        public string DeviceAuthorizationEndpoint { get; set; }

        /// <summary>
        /// Revocation Endpoint
        /// </summary>
        public string RevocationEndpoint { get; set; }

        /// <summary>
        /// Token Endpoint Authentication Methods Supported
        /// </summary>
        public IEnumerable<string> TokenEndpointAuthenticationMethodsSupported { get; set; }

        /// <summary>
        /// User Info Endpoint
        /// </summary>
        public string UserInfoEndpoint { get; set; }

        /// <summary>
        /// KeySet
        /// </summary>
        public JsonWebKeySet KeySet { get; set; }

        /// <summary>
        /// Policy
        /// </summary>
        public DiscoveryPolicy Policy { get; set; }

        /// <summary>
        /// Claims Supported
        /// </summary>
        public IEnumerable<string> ClaimsSupported { get; set; }

        /// <summary>
        /// error
        /// </summary>
        public string Error { get; set; }

        public Exception Exception { get; set; }
    }
}
