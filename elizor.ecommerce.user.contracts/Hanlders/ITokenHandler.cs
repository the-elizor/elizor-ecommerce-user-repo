using elizor.ecommerce.user.entities.discoverDocument;
using elizor.ecommerce.user.shared.Models;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.contracts.Hanlders
{
    public interface ITokenHandler
    {
        Task<IdentityDiscoveryDocumentResponse> GetDiscoveryDocumentAsync(string address);
        Task<IdentityTokenResponse> RequestPasswordTokenAsync(PasswordTokenRequest tokenRequest);
        //Task<ResponseBase> GetAccessToken(string request, string authanticationType);
    }
}
