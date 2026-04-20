using System;

public class OrderProcessor
{
    private PaymentSystem payment = new PaymentSystem();
    private Database db = new Database();
    private DeliverySystem delivery = new DeliverySystem();

    public void Checkout(ShoppingCart cart, string address)
    {
        double total = cart.GetTotal();

        if (!payment.ProcessPayment(total))
        {
            Console.WriteLine("Payment failed");
            return;
        }

        db.SaveOrder("Total: " + total);
        delivery.ArrangeDelivery(address);

        Console.WriteLine("Order completed!");
    }
}
