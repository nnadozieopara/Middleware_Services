namespace Middleware_Services.Services
{
    public abstract class BankWithdrawalService
    {
        public abstract void Withdraw(decimal amount, decimal balance);
    }
}
