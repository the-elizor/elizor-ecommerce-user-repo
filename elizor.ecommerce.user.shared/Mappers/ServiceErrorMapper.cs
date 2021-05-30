using elizor.ecommerce.user.shared.Contracts;
using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.shared.Mappers
{
    /// <summary>
    /// ServiceErrorMapper
    /// </summary>
    public class ServiceErrorMapper : IMapper<ResponseMessage, ResponseBase>
    {
        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public ResponseBase Map(ResponseMessage input) => new ResponseBase
        {
            IsSuccess = false,
            Error = input
        };
    }
}
