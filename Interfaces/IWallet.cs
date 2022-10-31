using System;
namespace Jala_university_Aula13
{
    public interface IWallet
    {
        int Id { get; set; }
        private const string WalletCurrency = "BRL";
        decimal Balance { get; }

        public void AddToBalance(decimal amount);
        
    }
}

