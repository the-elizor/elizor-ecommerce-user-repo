
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
            services.AddDbContext<UserContext>();
            #endregion

            #region Configurations

            #endregion

            #region Managers
            services.AddScoped<ILoginManager, LoginManager>();
            #endregion

            #region Repositories
            services.AddScoped<ILoginRepository, LoginRepository>();
            #endregion

            return services;
        }
    }
}
