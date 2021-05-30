// <copyright file="IErrorMessages.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.contracts.Common
{
    /// <summary>
    /// IErrorMessages
    /// </summary>
    public interface IErrorMessages
    {

        /// <summary>
        /// Gets the message server error.
        /// </summary>
        /// <returns></returns>
        ResponseMessage GetMessageServerError();

        /// <summary>
        /// Gets the message user not found error.
        /// </summary>
        /// <returns></returns>
        ResponseMessage GetMessageUserNotFoundError();
    }
}
