// <copyright file="ServiceCollectionExtensions.cs" company="Elizor (Pvt) Ltd">
// Copyright (c) Elizor (Pvt) Ltd, 2021 
//		All Rights Reserved.
//		This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//		Reproduction or distribution, in whole or in part, is strictly forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.user.business.Managers;
using elizor.ecommerce.user.contracts.Managers;
using elizor.ecommerce.user.contracts.Repositories;
using elizor.ecommerce.user.data.Repositories;
using elizor.ecommerce.user.dbcontext.tables;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using elizor.ecommerce.user.entities.configuration;
using elizor.ecommerce.user.contracts.Hanlders;
using Microsoft.EntityFrameworkCore;
using elizor.ecommerce.user.business.Handlers;
using elizor.ecommerce.user.shared.Contracts;
using elizor.ecommerce.user.shared.Models;
using elizor.ecommerce.user.shared.Mappers;
using elizor.ecommerce.user.contracts.Common;
using elizor.ecommerce.user.resources.Exceptions;

namespace elizor.ecommerce.user.api.Models
{
    /// <summary>
    /// ServiceCollectionExtensions
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            services.AddDbContextPool<UserContext>(options => options.UseMySql(configuration.GetConnectionString("DefaultConnection")));
            #endregion

            #region Configurations
            services.Configure<LoginConfiguration>(configuration.GetSection("IdentityServer"));
            #endregion

            #region Managers
            services.AddScoped<ILoginManager, LoginManager>();
            services.AddScoped<IUserSecurityManager, UserSecurityManager>();
            #endregion

            #region Repositories
            services.AddScoped<ILoginRepository, LoginRepository>();
            #endregion

            #region Handlers
            services.AddScoped<ITokenHandler, TokenHandler>();
            #endregion

            #region Mappers
            // shared
            services.AddSingleton<IMapper<ResponseMessage, ResponseBase>, ServiceErrorMapper>();
            services.AddSingleton<IMapper<Object, ResponseBase>, ServiceResponseMapper>();
            #endregion

            #region Resourse
            services.AddSingleton<IErrorMessages, ErrorMessages>();
            #endregion

            return services;
        }
    }
}
