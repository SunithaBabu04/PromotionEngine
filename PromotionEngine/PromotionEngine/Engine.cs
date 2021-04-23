//-----------------------------------------------------------------------
// <copyright file="Engine.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PromotionEngine.Interface;
    using PromotionEngine.Model;

    /// <summary>
    /// Engine Class.
    /// </summary>
    public class Engine : IEngine
    {
        /// <summary>
        /// Calculate total price for all the porducts in the order.
        /// </summary>
        /// <param name="order">Order details.</param>
        /// <param name="promotions">Promotion details.</param>
        /// <param name="products">Product details.</param>
        /// <returns>Calculated value.</returns>
        public decimal CalculateTotalPrice(Order order, List<Promotion> promotions, List<Product> products)
        {
            decimal calcPrice = 0M;

            // loop through the products in a parituclar order
            foreach (var orderItem in order.Products)
            {
                // select if there aer any promotions to the product in the order
                Promotion prom = promotions.Where(p => p.ProductId == orderItem.ProductId).FirstOrDefault();

                // if there is a single entry in pormotions for the porduct
                if (promotions.Where(p => p.PromotionId == prom.PromotionId).Count() == 1)
                {
                    // apply promotion price for quantities in promotion, for the rest of the product, apply product price
                    calcPrice += ((orderItem.OrderQuantity / prom.PromotionQty) * prom.PromotionPrice) + ((orderItem.OrderQuantity % prom.PromotionQty) * products.FirstOrDefault(p => p.ProductId == orderItem.ProductId).ProductPrice);
                }
                else if (promotions.Where(p => p.PromotionId == prom.PromotionId).Count() > 1)
                {
                    // if there is a multiplce entry in pormotions for the porduct, like bundle , C + D

                }
                else
                {
                    // if there is no pormotions for the product, like product F
                }

            }

            return calcPrice;
        }
    }
}
