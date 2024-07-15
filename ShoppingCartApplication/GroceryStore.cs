using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class GroceryStore
    {
        private List<Product> products;
        private ShoppingCart cart;

        public GroceryStore(ShoppingCart shoppingCart)
        {
            cart = shoppingCart;
            var generator = new ProductGenerator();
            products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var product = generator.GenerateProduct();
                if (product.Category == ProductCategory.Food)
                {
                    products.Add(product);
                }
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Grocery Store Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void AddToCart(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                cart.AddItem(product);
                Console.WriteLine($"{productName} added to the cart.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }

}