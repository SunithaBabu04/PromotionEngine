//-----------------------------------------------------------------------
// <copyright file="ServiceMock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngineTest
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using PromotionEngine;
    using PromotionEngine.Interface;

    /// <summary>
    /// Service Mock.
    /// </summary>
    public class ServiceMock
    {
        protected IServiceProvider serviceProvider;
        protected IEngine engine;

        public IServiceProvider BuildServiceProvider()
        {
            var builder = new ConfigurationBuilder();
            IConfiguration Configuration = builder.Build();

            var services = new ServiceCollection();
            services.AddInjection();
            serviceProvider = services.BuildServiceProvider();

            engine = serviceProvider.GetService<IEngine>();
            return serviceProvider;
        }
    }
}
