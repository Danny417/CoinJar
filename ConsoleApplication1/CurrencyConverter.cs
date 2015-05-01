using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoinJar
{
    public static class CurrencyConverter
    {
        private static readonly Dictionary<string, decimal> rates;

        static CurrencyConverter()
        {
            rates = (ConfigurationManager.GetSection("CurrencyRate") as System.Collections.Hashtable)
                 .Cast<System.Collections.DictionaryEntry>()
                 .ToDictionary(n => n.Key.ToString(), n => decimal.Parse(n.Value.ToString()));
        }

        public static decimal convert(Account acc, string CurrencyCode)
        {
            decimal ratio = decimal.Divide(rates[CurrencyCode], rates[acc.currencyCode]);
            return decimal.Multiply(acc.currency, ratio);
        }
    }
}
