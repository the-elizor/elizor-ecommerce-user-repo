// <copyright file="ConnectionString.cs" company="Elizor (Pvt) Ltd">
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

namespace elizor.ecommerce.user.entities.connection
{
    /// <summary>
    /// ConnectionString
    /// </summary>
    public static class ConnectionString
    {
        /// <summary>
        /// Gets or sets the client connection string.
        /// </summary>
        /// <value>
        /// The client connection string.
        /// </value>
        public static string ClientConnectionString { get; set; }
    }
}
