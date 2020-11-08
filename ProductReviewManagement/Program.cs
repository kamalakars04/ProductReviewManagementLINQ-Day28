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
            ProductReviewManagement management = new ProductReviewManagement();

            // UC 1 Retrieves the top three rated products.
            management.RetrieveTopThreeRatedProducts();
        }
    }
}
