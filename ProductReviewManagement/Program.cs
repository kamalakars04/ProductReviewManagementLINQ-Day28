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
            ProductReviewManagement management = new ProductReviewManagement();

            // UC 2 Retrieves the top three rated products.
            Console.WriteLine("Retrieves the top three rated products");
            management.RetrieveTopThreeRatedProducts();
            Console.WriteLine("\n\n");

            // UC 3 Retrieve withe the rating greater than three.
            Console.WriteLine("Retrieve withe the rating greater than three");
            management.RetrievewithRatingGreaterThanThree();
            Console.WriteLine("\n\n");

        }
    }
}
