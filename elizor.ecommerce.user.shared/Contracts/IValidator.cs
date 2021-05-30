// <copyright file="IValidator.cs" company="Elizor (Pvt) Ltd">
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

namespace elizor.ecommerce.user.shared.Contracts
{
    /// <summary>
    /// IValidator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IDisposable" />
    public interface IValidator<in T> : IDisposable
    {
        /// <summary>
        /// Validates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="messages">The messages.</param>
        /// <returns></returns>
        bool Validate(T obj, out ResponseMessage message);

        /// <summary>
        /// Is match
        /// </summary>
        /// <param name="id">Id for match</param>
        bool IsMatch(string id);

        /// <summary>
        /// To get validator order
        /// </summary>
        int GetOrder();
    }
}
