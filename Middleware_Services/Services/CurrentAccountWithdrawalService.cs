namespace Middleware_Services.Services
{
    public class CurrentAccountWithdrawalService : BankWithdrawalService
    {
        public override void Withdraw(decimal amount, decimal balance)
        {
            if (balance - amount >=0)
            {
                Console.WriteLine("Successful Withdrawal");
            }
        }
    }
}
