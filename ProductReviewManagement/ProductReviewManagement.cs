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
    using System.Linq;

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
                new ProductReview(1, 2, 5, "Good", true),
                new ProductReview(2, 15, 1, "bad", false),
                new ProductReview(3, 4, 4, "Good", true),
                new ProductReview(4, 4, 1, "bad", false),
                new ProductReview(5, 4, 3, "Average", true),
                new ProductReview(6, 15, 1, "Average", false),
                new ProductReview(6, 1, 4, "Good", true),
                new ProductReview(6, 5, 3, "Average", false),
                new ProductReview(7, 10, 5, "Good", true),
                new ProductReview(8, 18, 5, "Good", true),
                new ProductReview(9, 15, 5, "Good", true),
                new ProductReview(9, 19, 4, "Good", true),
                new ProductReview(9, 5, 5, "Good", true),
                new ProductReview(10, 12, 2, "Bad", false),
                new ProductReview(11, 21, 3, "Average", true),
                new ProductReview(12, 11, 3, "Average", false)
            };
        }

        /// <summary>
        /// UC 2 Retrieves the top three rated products.
        /// </summary>
        public void RetrieveTopThreeRatedProducts()
        {
            var result = (from product in productList
                          orderby product.Rating descending
                          select product).Take(3);
            
            result.ToList().ForEach(product => product.Display());
        }

        /// <summary>
        /// UC 3 Retrieve withe the rating greater than three.
        /// </summary>
        public void RetrievewithRatingGreaterThanThree()
        {
            var result = from product in productList
                         where product.Rating > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9)
                         orderby product.Rating
                         select product;

            result.ToList().ForEach(product => product.Display());
        }

        /// <summary>
        /// UC 4 Gets the count of each product reviews.
        /// </summary>
        public void GetCountOfReviews()
        {
            var result = productList.GroupBy(product => product.ProductId);
            result.ToList().ForEach(element => Console.WriteLine($"ProductId : {element.Key} \t ReviewCount : {element.Count()}"));     
        }

        /// <summary>
        /// UC 5 Gets the product identifier and review.
        /// </summary>
        public void GetProductIdAndReview()
        {
            var result = from product in productList
                         select new {product.ProductId , product.Review };

            result.ToList().ForEach(element => Console.WriteLine($"ProductId : {element.ProductId} \t Review : {element.Review}"));
        }

        /// <summary>
        /// UC 6 Skips the top five.
        /// </summary>
        public void SkipTopFive()
        {
            var result = productList.Skip(5);
            result.ToList().ForEach(product => product.Display());
        }

        /// <summary>
        /// UC 7 Gets the product identifier and review.
        /// </summary>
        public void GetOnlyProductIdAndReview()
        {
            var result = from product in productList
                         select new { product.ProductId, product.Review };

            result.ToList().ForEach(element => Console.WriteLine($"ProductId : {element.ProductId} \t Review : {element.Review}"));
        }
    }
}
