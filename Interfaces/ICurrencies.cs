using System;
namespace Jala_university_Aula13.Interfaces
{
    public interface ICurrencies
    {
        public Dictionary<string, decimal> Currency { get; set; }
        public decimal getCurrency(string outgoingCurrency);
    }
}

