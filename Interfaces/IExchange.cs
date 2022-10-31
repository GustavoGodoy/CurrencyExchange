using System;
namespace Jala_university_Aula13
{
    public interface IExchange { 
        public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount);
        public void CustomExcepctions(string outgoingCurrency, decimal amount);
    }
}

