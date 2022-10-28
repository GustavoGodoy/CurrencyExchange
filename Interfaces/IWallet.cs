using System;
namespace Jala_university_Aula13
{
    public interface IWallet
    {
        int Id { get; set; }
        private const string WalletCurrency = "BRL";
        decimal Balance { get; set; }

        public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount);
        public void AddToBalance(decimal amount);
        public void CustomExcepctions(string outgoingCurrency, decimal amount);
        public decimal GetBalance();
    }
}

