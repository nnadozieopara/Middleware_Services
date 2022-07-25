namespace Middleware_Services.Services
{
    public class SavingsAccountWithdrawal : BankWithdrawalService
    {
        public override void Withdraw(decimal amount, decimal balance)
        {
            if (balance -amount > 1000 )
            {
                Console.WriteLine($"You have successfully withdrawn {amount} from your account and your balance is {balance - amount}");
            }
            else
            {
                Console.WriteLine($"Insufficient balance, you can't withdraw {amount}");
            }
        }
    }
}
