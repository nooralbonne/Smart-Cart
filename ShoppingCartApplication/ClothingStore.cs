using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ClothingStore
    {
        private ProductGenerator productGenerator = new ProductGenerator();

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(productGenerator.GenerateProduct(ProductCategory.Clothing));
            }
            return products;
        }
    }
}

