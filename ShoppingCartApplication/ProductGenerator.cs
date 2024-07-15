using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        private static readonly Random random = new Random();
        private static readonly string[] productNames = { "Apple", "T-Shirt", "Laptop", "Book", "Banana", "Jeans", "Headphones", "Shirt" };

        public Product GenerateProduct()
        {
            string name = productNames[random.Next(productNames.Length)];
            decimal price = Math.Round((decimal)(random.NextDouble() * 100), 2);
            ProductCategory category = (ProductCategory)random.Next(Enum.GetValues(typeof(ProductCategory)).Length);

            return new Product(name, price, category);
        }
    }
}
