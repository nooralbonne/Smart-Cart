// ShoppingCart.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartApplication
{
    public class ShoppingCart
    {
        private List<Product> items = new List<Product>();

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

        public List<Product> ViewCart()
        {
            return items;
        }

        public decimal CalculateTotalCost()
        {
            return items.Sum(item => item.Price);
        }
    }
}
