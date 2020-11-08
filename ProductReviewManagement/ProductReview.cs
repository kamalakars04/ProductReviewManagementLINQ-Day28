// --------------------------------------------------------------------------------------------------------------------
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

    class ProductReview
    {
        /// <summary>
        /// Gets or sets all elements.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReview"/> class.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="userId">The user identifier.</param>
        /// <param name="rating">The rating.</param>
        /// <param name="review">The review.</param>
        /// <param name="isLike">if set to <c>true</c> [is like].</param>
        public ProductReview(int productId, int userId, double rating, string review, bool isLike)
        {
            this.ProductId = productId;
            this.UserId = userId;
            this.Rating = rating;
            this.Review = review;
            this.IsLike = isLike;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"ProductId : {ProductId} \t UserId : {UserId} \t Rating : {Rating} \t Review : {Review} \t IsLike : {IsLike}");
        }

    }
}
