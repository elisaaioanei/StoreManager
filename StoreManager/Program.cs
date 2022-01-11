using StoreManager.Controller;
using StoreManager.Model;
using System;
using System.Collections.Generic;

namespace StoreManager
{
    class Program
    {
        private static readonly ProductController productController = new ProductController();

        static void Main(string[] args)
        {
            var products = new List<Product>();

            Console.WriteLine("1. List products");
            Console.WriteLine("2. Create product");
            Console.WriteLine("3. Update product");
            Console.WriteLine("4. Delete product");
            Console.WriteLine("5. Place order");

            Console.ReadLine(); // apasati 1

            // Pentru 1 
            Console.WriteLine("Id. Name, Price");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}. {product.Name} {product.Price}");
            }

            Console.ReadLine(); // apasati 4

            // Pentru 4
            Console.WriteLine("Select product Id");
            var productId = Convert.ToInt32(Console.ReadLine());
            productController.Delete(productId);
        }
    }
}
