// <copyright file="ResponseMessage.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.shared.Models
{
    /// <summary>
    /// Message
    /// </summary>
    public class ResponseMessage
    {
        /// <summary>
        /// Gets or sets the message code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the message type
        /// </summary>
        public string MessageType { get; set; }
    }
}
