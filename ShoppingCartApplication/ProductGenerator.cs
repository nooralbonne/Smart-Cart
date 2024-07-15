// ProductGenerator.cs
using System;
using System.Collections.Generic;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        private static Random random = new Random();

        private static Dictionary<ProductCategory, string[]> categoryProducts = new Dictionary<ProductCategory, string[]>
        {
            { ProductCategory.Food, new string[] { "Apple", "Banana", "Orange", "Milk", "Bread" } },
            { ProductCategory.Clothing, new string[] { "T-Shirt", "Jeans", "Shirt", "Jacket", "Hat" } },
            { ProductCategory.Electronics, new string[] { "Laptop", "Headphones", "Smartphone", "Camera", "Tablet" } },
            { ProductCategory.Others, new string[] { "Book", "Pen", "Notebook", "Bag", "Watch" } }
        };

        public Product GenerateProduct(ProductCategory category)
        {
            string[] products = categoryProducts[category];
            string name = products[random.Next(products.Length)];
            decimal price = Math.Round((decimal)(random.NextDouble() * 100), 2);

            return new Product(name, price, category);
        }
    }
}
