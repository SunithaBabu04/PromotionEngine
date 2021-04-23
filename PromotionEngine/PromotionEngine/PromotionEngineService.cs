//-----------------------------------------------------------------------
// <copyright file="PromotionEngineService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using PromotionEngine.Interface;
    using PromotionEngine.Model;

    /// <summary>
    /// Promotion Engine Service.
    /// </summary>
    public class PromotionEngineService
    {
        private readonly IEngine engineI;

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionEngineService"/> class.
        /// </summary>
        /// <param name="engine">Interface.</param>
        /// <returns>Service collection object.</returns>
        public PromotionEngineService(IEngine engine)
        {
            this.engineI = engine;
        }

        /// <summary>
        /// Calculate order Price.
        /// </summary>
        /// <param name="order">Order details.</param>
        /// <param name="promotions">Promotion details.</param>
        /// <param name="products">Product details.</param>
        /// <returns>Calculated value.</returns>
        public decimal CalculateOrderPrice(Order order, List<Promotion> promotions, List<Product> products)
        {
            return this.engineI.CalculateTotalPrice(order, promotions, products);
        }
    }
}
