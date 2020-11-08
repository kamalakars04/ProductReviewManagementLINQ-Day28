﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductReviewManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ProductReviewManagement
    {
        List<ProductReview> productList;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReviewManagement"/> class.
        /// UC 1 Adding elements to list
        /// </summary>
        public ProductReviewManagement()
        {
            productList = new List<ProductReview>
            {
                new ProductReview(1, 9, 4, "Good", true),
            new ProductReview(2, 15, 1, "bad", false),
            new ProductReview(3, 4, 4, "Good", true),
            new ProductReview(4, 4, 1, "bad", false),
            new ProductReview(5, 4, 3, "Average", true),
            new ProductReview(6, 15, 1, "Average", false),
            new ProductReview(7, 10, 5, "Good", true),
            new ProductReview(8, 18, 5, "Good", true),
            new ProductReview(9, 15, 4, "Good", true),
            new ProductReview(10, 12, 2, "Bad", false),
            new ProductReview(11, 21, 3, "Average", true),
            new ProductReview(12, 11, 3, "Average", false)
            };
        }



    }
}
