using System;

class Program
{
    static void Main()
    {
        var cart = new ShoppingCart();
        cart.AddProduct(new Product { Name = "Phone", Price = 500 });

        var processor = new OrderProcessor();
        processor.Checkout(cart, "Almaty");

        Console.ReadLine();
    }
}
