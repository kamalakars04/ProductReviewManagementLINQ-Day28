// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductReviewManagement
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Uc 1 Adding elements
            ProductReviewManagement management = new ProductReviewManagement("list");

            // UC 2 Retrieves the top three rated products.
            Console.WriteLine("Retrieves the top three rated products");
            management.RetrieveTopThreeRatedProducts();
            Console.WriteLine("\n\n");

            // UC 3 Retrieve withe the rating greater than three.
            Console.WriteLine("Retrieve withe the rating greater than three");
            management.RetrievewithRatingGreaterThanThree();
            Console.WriteLine("\n\n");

            // UC 4 Gets the count of each product reviews.
            Console.WriteLine(" Gets the count of each product reviews");
            management.GetCountOfReviews();
            Console.WriteLine("\n\n");

            // UC 5 Gets the productid and review.
            Console.WriteLine("Gets the productid and review");
            management.GetProductIdAndReview();
            Console.WriteLine("\n\n");

            // UC 6 Skips the top five.
            Console.WriteLine("Skips the top five");
            management.SkipTopFive();
            Console.WriteLine("\n\n");

            // UC 7 Gets the productid and review.
            Console.WriteLine("Gets the productid and review");
            management.GetOnlyProductIdAndReview();
            Console.WriteLine("\n\n");

            // UC 8 Create DataTable
            ProductReviewManagement managementOne = new ProductReviewManagement("table");

            // UC 9 Get products with isLike true
            Console.WriteLine("Get products with isLike true");
            managementOne.GetProductIsLikeTrue();
            Console.WriteLine("\n\n");

            // UC 10 Get avg rating
            Console.WriteLine("Get avg rating");
            managementOne.GetAvgRatingOfEachProduct();
            Console.WriteLine("\n\n");

            // UC 11 Get products with review Good
            Console.WriteLine(" Get products with review Good");
            managementOne.GetProductsWithReviewNice();
            Console.WriteLine("\n\n");
        }
    }
}
