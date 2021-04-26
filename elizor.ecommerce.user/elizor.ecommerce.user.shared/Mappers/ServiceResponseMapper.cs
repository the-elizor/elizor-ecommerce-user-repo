using elizor.ecommerce.user.shared.Contracts;
using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.shared.Mappers
{
    public class ServiceResponseMapper : IMapper<Object, ResponseBase>
    {
        /// <summary>
        /// Map success response
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ResponseBase Map(object input)
        {
            return new ResponseBase
            {
                Result = input,
                IsSuccess = true,
                Error = new ResponseMessage { Code = "", Message = "" }

            };
        }
    }
}
