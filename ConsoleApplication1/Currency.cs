using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public abstract class Account
    {
        public decimal currency { get; protected set; }
        public string currencyCode { get; protected set; }

        protected Account(string currencyCode, decimal currency)
        {
            this.currencyCode = currencyCode;
            this.currency = currency;
        }
    }
}
