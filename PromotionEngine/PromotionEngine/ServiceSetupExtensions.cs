//-----------------------------------------------------------------------
// <copyright file="ServiceSetupExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngine
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using PromotionEngine.Interface;

    /// <summary>
    /// Service SetUp Extension.
    /// </summary>
    public static class ServiceSetupExtensions
    {
        /// <summary>
        /// Add class to the Container.
        /// </summary>
        /// <param name="services">Service.</param>
        /// <returns>Service collection object.</returns>
        public static IServiceCollection AddInjection(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<IEngine, Engine>();
            return services;
        }
    }
}
