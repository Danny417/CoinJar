using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public abstract class Asset
    {
        public decimal currency { get; protected set; }
        public string currencyCode { get; protected set; }

        protected Asset(string currencyCode, decimal currency)
        {
            this.currencyCode = currencyCode;
            this.currency = currency;
        }
    }
}
