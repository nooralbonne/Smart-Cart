// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            var productGenerator = new ProductGenerator();

            while (true)
            {
                Console.WriteLine("Welcome to the Smart Shopping Cart Application!");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Shopping Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ShopAtStore(cart, productGenerator, ProductCategory.Food);
                        break;
                    case 2:
                        ShopAtStore(cart, productGenerator, ProductCategory.Clothing);
                        break;
                    case 3:
                        ViewCart(cart);
                        break;
                    case 4:
                        CalculateTotalCost(cart);
                        break;
                    case 5:
                        Console.WriteLine("Thank you for shopping with us!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShopAtStore(ShoppingCart cart, ProductGenerator productGenerator, ProductCategory category)
        {
            Console.WriteLine($"Shopping at {category} Store");
            List<Product> products = new List<Product>();

            for (int i = 0; i < 10; i++)
            {
                products.Add(productGenerator.GenerateProduct(category));
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("Enter product name to add to cart:");
            string productName = Console.ReadLine();

            var selectedProduct = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (selectedProduct != null)
            {
                cart.AddItem(selectedProduct);
                Console.WriteLine($"{productName} added to the cart.");
            }
            else
            {
                Console.WriteLine("Product not found in the available products.");
            }
        }

        static void ViewCart(ShoppingCart cart)
        {
            var items = cart.ViewCart();
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                Console.WriteLine("Items in your cart:");
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Enter product name to remove from cart or press Enter to continue:");
                string removeItem = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(removeItem))
                {
                    cart.RemoveItem(removeItem);
                }
            }
        }

        static void CalculateTotalCost(ShoppingCart cart)
        {
            Console.WriteLine($"Total Cost: ${cart.CalculateTotalCost()}");
        }
    }
}
