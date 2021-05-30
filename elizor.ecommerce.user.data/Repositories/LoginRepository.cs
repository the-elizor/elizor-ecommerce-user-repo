// <copyright file="LoginRepository.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.contracts.Repositories;
using elizor.ecommerce.user.dbcontext.tables;
using elizor.ecommerce.user.entities.checkUser;
using elizor.ecommerce.user.entities.test;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.data.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        /// <summary>
        /// Usercontext
        /// </summary>
        private readonly UserContext _userContext;

        /// <summary>
        /// ILogger for error logs
        /// </summary>
        private readonly ILogger<LoginRepository> _logger;

        public LoginRepository(UserContext userContext,
                               ILogger<LoginRepository> logger)
        {
            _userContext = userContext;
            _logger = logger;
        }

        public CheckUserResponse CheckUserExists(CheckUserRequest request)
        {
            try
            {
                var user = _userContext.eep_t_customer.FirstOrDefault(i => i.EmailAddress == request.Username && i.Status == 1);
                return new CheckUserResponse { Email = "test@gmail.com", Username = "password" };
                //if (user != null)
                //{
                //    return new CheckUserResponse
                //    {
                //        Email = user.EmailAddress,
                //        Username = ""
                //    };
                //}
                //return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }
    }
}
