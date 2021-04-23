﻿//-----------------------------------------------------------------------
// <copyright file="IEngine.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngine.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using PromotionEngine.Model;

    /// <summary>
    /// IEngine Interface.
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Calculate total price for all the porducts in the order.
        /// </summary>
        /// <param name="order">Order details.</param>
        /// <param name="promotions">Promotion details.</param>
        /// <param name="products">Product details.</param>
        /// <returns>Calculated value.</returns>
        decimal CalculateTotalPrice(Order order, List<Promotion> promotions, List<Product> products);
    }
}
