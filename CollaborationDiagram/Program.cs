using System;

class Program
{
    static void Main()
    {
        var sender = new Account { Balance = 1000 };
        var receiver = new Account { Balance = 200 };

        var bank = new BankingSystem();
        bank.Transfer(sender, receiver, 300);

        Console.ReadLine();
    }
}
