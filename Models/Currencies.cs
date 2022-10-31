using System;

namespace Jala_university_Aula13
{
    public static class Currencies
    {
        public static Dictionary<string, decimal> Currency { get; set; } = new Dictionary<string, decimal>()
        {   
            {"USD", 0.18M},
            {"CAD", 0.90M},
            {"EUR", 0.20M},
        };

        public static decimal getCurrency(string outgoingCurrency)
        {
            if (!Currency.TryGetValue(outgoingCurrency, out var to))
            {
                throw new ArgumentException("Invalid currency");
            }
            return to;
        }
    }
}

