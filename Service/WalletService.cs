using System;
namespace Jala_university_Aula13
{
    public class WalletService : IWalletService
    {
        private readonly IWallet _wallet;

        public WalletService(IWallet wallet)
        {
              _wallet = wallet;
        }

        public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount)
        {
         
            CustomExcepctions(outgoingCurrency, amount);

            var total = (amount * Currencies.getCurrency(outgoingCurrency)) - 0.01M;

            return new Tuple<string, decimal>(outgoingCurrency, total);
        }

        public void CustomExcepctions(string outgoingCurrency, decimal amount)
        {

            if (amount < 50)
            {
                throw new InvalidOperationException("amount below expected");
            }

            if (amount > _wallet.Balance)
            {
                throw new ArgumentException();
            }
        }

        public void AddToBalance(decimal amount)
        {
            _wallet.AddToBalance(amount);
        }

        public decimal GetBalance()
        {
            return _wallet.Balance;
        }
    }
}

