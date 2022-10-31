using System;
namespace Jala_university_Aula13
{
    public class Exchange : IExchange
    {
        private readonly IWallet _wallet;

        public Exchange(IWallet wallet)
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

    }
}

