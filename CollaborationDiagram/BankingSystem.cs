public class BankingSystem
{
    private NotificationSystem notifier = new NotificationSystem();

    public void Transfer(Account sender, Account receiver, double amount)
    {
        if (sender.Balance < amount)
        {
            notifier.Notify("Insufficient funds");
            return;
        }

        sender.Withdraw(amount);
        receiver.Deposit(amount);

        notifier.Notify("Transfer successful");
    }
}
