using System.Collections.Generic; // Added the necessary namespace for List<T>

namespace ListsApp
{
	// Create a custom class called Product. In C#, classes are used to define objects.
	public class Product
	{
		public string Name { get; set; }  // Property to store the product's name
		public double Price { get; set; } // Property to store the product's price
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a list to store Product objects and initialize it with some products
			List<Product> products = new List<Product> {
				new Product { Name = "Apple", Price = 0.80 },    // Add a new Product object (Apple) to the list
                new Product { Name = "Banana", Price = 0.50 },   // Add another Product object (Banana) to the list
                new Product { Name = "Cherries", Price = 3.70 }  // Add a third Product object (Cherries) to the list
            };

			// Add another product to the list using the Add() method
			products.Add(new Product { Name = "Berries", Price = 2.99 });



			// Returns a list called cheapProducts with a price less than 1.00
			List<Product> cheapProducts = products.Where(p => p.Price < 1.00).ToList();



			// Display the products in the list
			Console.WriteLine("Available products:");
			foreach (Product product in products)
			{
				Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
			}

			Console.WriteLine(); // Add a new line for spacing

			// print out cheap products list
			Console.WriteLine("Available products for less than $1: ");
			foreach (Product product in cheapProducts)
			{
				Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
			}  


			Console.ReadKey();
		}
	}
}