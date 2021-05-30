// <copyright file="ErrorMessages.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.contracts.Common;
using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.resources.Exceptions
{
    public class ErrorMessages : IErrorMessages
    {
        /// <summary>
        /// Gets the message server error.
        /// </summary>
        /// <returns></returns>
        public ResponseMessage GetMessageServerError() => new ResponseMessage
        {
            Code = "E0001",
            Message = error.E0001
        };

        ResponseMessage IErrorMessages.GetMessageUserNotFoundError() => new ResponseMessage
        {
            Code = "E0002",
            Message = error.E0002
        };
    }
}
