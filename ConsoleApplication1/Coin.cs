using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoinJar
{
    public abstract class Coin : Asset
    {
        public decimal volume { get; protected set; }

        protected Coin(string currencyCode, decimal currency, decimal unitVolume) : base(currencyCode, currency)
        {
            this.volume = unitVolume;
        }
    }
}
