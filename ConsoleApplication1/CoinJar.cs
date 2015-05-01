using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoinJar
{
    public class CoinJar : Account
    {
        private readonly decimal volume;
        private decimal volumeRemaining { get; set; }
        private Boolean isMultiCurrency { get; set; }
        private List<Coin> coins;

        public CoinJar() : this(32, false)
        {
            
        }

        public CoinJar(decimal volume, Boolean isMultiCurrency) : base("USD", 0)
        {
            if (volume < 0)
            {
                throw new Exception("The volume of jar is less than 0");
            }
            this.volume = volume;             
            this.isMultiCurrency = isMultiCurrency;
            ClearJar();
        }

        public void Insert(Coin coin)
        {
            if (coin == null) return;
            if (!isMultiCurrency && coin.GetType() != typeof(USDCoin))
            {
                throw new Exception("This jar only accept US coinage.");
            }
            if (decimal.Subtract(volumeRemaining, coin.volume) < 0)
            {
                throw new Exception("This jar is full.");
            }
            coins.Add(coin);
            volumeRemaining -= coin.volume;
            currency += CurrencyConverter.convert(coin, currencyCode);
        }

        public void ClearJar()
        {
            volumeRemaining = volume;
            coins = new List<Coin>();
            currency = 0;
            /*Console.WriteLine("Jar cleared");
            Console.WriteLine("The total cents of jar is " + amount);
            Console.WriteLine("The volume of jar is " + volumeRemaining);*/
        }
    }
}
