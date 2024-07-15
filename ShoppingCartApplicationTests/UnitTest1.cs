using Microsoft.VisualBasic;
using ShoppingCartApplication;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System.ComponentModel;
using System.IO;
using System;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddItem()
        {
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.99m, ProductCategory.Others);

            cart.AddItem(product);

            Assert.Single(cart.ViewCart());
        }

        [Fact]
        public void TestRemoveItem()
        {
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.99m, ProductCategory.Others);

            cart.AddItem(product);
            cart.RemoveItem("Test Product");

            Assert.Empty(cart.ViewCart());
        }

        [Fact]
        public void TestCalculateTotalCost()
        {
            var cart = new ShoppingCart();
            var product1 = new Product("Product 1", 10.99m, ProductCategory.Others);
            var product2 = new Product("Product 2", 20.50m, ProductCategory.Others);

            cart.AddItem(product1);
            cart.AddItem(product2);

            Assert.Equal(31.49m, cart.CalculateTotalCost());
        }
    }
}



