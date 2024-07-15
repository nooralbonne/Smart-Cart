using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(string productName)
        {
            var product = items.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                items.Remove(product);
            }
            else
            {
                Console.WriteLine("Product not found in the cart.");
            }
        }

        public void ViewCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public decimal CalculateTotalCost()
        {
            return items.Sum(item => item.Price);
        }
    }
}