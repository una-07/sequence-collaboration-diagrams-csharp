using System;

public class PaymentSystem
{
    public bool ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment...");
        return amount > 0;
    }
}
