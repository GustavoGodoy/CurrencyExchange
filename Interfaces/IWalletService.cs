using System;
namespace Jala_university_Aula13
{
    public interface IWalletService { 
        public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount);
        public void CustomExcepctions(string outgoingCurrency, decimal amount);
        void AddToBalance(decimal amount);
        decimal GetBalance();
    }
}

