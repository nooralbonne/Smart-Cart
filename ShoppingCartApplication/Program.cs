namespace ShoppingCartApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            var groceryStore = new GroceryStore(cart);
            var clothingStore = new ClothingStore(cart);

            while (true)
            {
                Console.WriteLine("Welcome to the Smart Shopping Cart Application!");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Shopping Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        groceryStore.DisplayProducts();
                        Console.WriteLine("Enter product name to add to cart:");
                        string groceryItem = Console.ReadLine();
                        groceryStore.AddToCart(groceryItem);
                        break;
                    case 2:
                        clothingStore.DisplayProducts();
                        Console.WriteLine("Enter product name to add to cart:");
                        string clothingItem = Console.ReadLine();
                        clothingStore.AddToCart(clothingItem);
                        break;
                    case 3:
                        cart.ViewCart();
                        Console.WriteLine("Enter product name to remove from cart or press Enter to continue:");
                        string removeItem = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(removeItem))
                        {
                            cart.RemoveItem(removeItem);
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Total Cost: ${cart.CalculateTotalCost()}");
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
    }
}
