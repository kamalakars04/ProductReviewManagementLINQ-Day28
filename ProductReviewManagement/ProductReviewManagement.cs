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
    using System.Data;

    public class ProductReviewManagement
    {
        List<ProductReview> productList;
        DataTable table;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReviewManagement"/> class.
        /// UC 1 Adding elements to list
        /// </summary>
        public ProductReviewManagement(string type)
        {
            if(type == "list")
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
            if(type == "table")
            {
                table = new DataTable();
                table.Columns.Add("ProductId", typeof(int));
                table.Columns.Add("UserId", typeof(int));
                table.Columns.Add("Rating", typeof(double));
                table.Columns.Add("Review",typeof(string));
                table.Columns.Add("IsLike", typeof(bool));
                table.Rows.Add(1, 1, 5, "Good", true);
                table.Rows.Add(2, 3, 3, "Average", true);
                table.Rows.Add(3, 4, 4, "Good", true);
                table.Rows.Add(4, 5, 5, "Good", true);
                table.Rows.Add(5, 4, 3, "Average", true);
                table.Rows.Add(6, 5, 1, "Bad", false);
                table.Rows.Add(7, 10, 5, "Good", true);
                table.Rows.Add(8, 10, 5, "Good", true);
                table.Rows.Add(9, 3, 4, "Good", true);
                table.Rows.Add(10, 2, 2, "Bad", false);
                table.Rows.Add(11, 3, 3, "Average", true);
                table.Rows.Add(12, 1, 3, "Average", false);
                table.Rows.Add(6, 1, 4, "Good", true);
                table.Rows.Add(1, 2, 5, "Good", true);
                table.Rows.Add(8, 20, 1, "bad", false);
            }
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

        /// <summary>
        /// UC 9 Gets the product is like true.
        /// </summary>
        public void GetProductIsLikeTrue()
        {
            var result = from product in table.AsEnumerable()
                         where product.Field<bool>("IsLike") == true
                         select product;
            foreach(var product in result)
            {
                Console.WriteLine($"ProductId : {product.Field<int>("ProductId")} \t " +
                 $"UserId : {product.Field<int>("UserId")} \t " +
                 $"Rating : {product.Field<double>("Rating")} \t " +
                 $"Review : {product.Field<string>("Review")} \t " +
                 $"IsLike : {product.Field<bool>("IsLike")}"
                 );
            }
        }

        /// <summary>
        /// UC 10 Gets the average rating of each product.
        /// </summary>
        public void GetAvgRatingOfEachProduct()
        {
            var result = from product in table.AsEnumerable()
                         group product by (product.Field<int>("ProductId")) into g
                         select new { g.Key, AverageRating = g.Average(x => x.Field<double>("Rating")) };

            foreach (var product in result)
            {
                Console.WriteLine($"ProductId : {product.Key} \t " +
                 $"AverageRating : {product.AverageRating} \t"
                 );
            }
        }
    }
}
