using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class USDCoin : Coin
    {
        enum Volume
        { //volume in fl oz. * 10000
            Penny = 122,
            Nickel = 243,
            Dime = 115,
            Quarter = 270,
            HalfDollar = 534,
            Dollar = 800
        };

        private USDCoin(decimal currency, Volume volume)
            : base("USD", currency, (decimal)volume / 10000)
        {
        }
        
        public static USDCoin Penny
        {
            get
            {
                return new USDCoin(0.01M, Volume.Penny);
            }
        }

        public static USDCoin Nickel
        {
            get
            {
                return new USDCoin(0.05M, Volume.Nickel);
            }
        }

        public static USDCoin Dime
        {
            get
            {
                return new USDCoin(0.1M, Volume.Dime);
            }
        }

        public static USDCoin Quarter
        {
            get
            {
                return new USDCoin(0.25M, Volume.Quarter);
            }
        }

        public static USDCoin HalfDollar
        {
            get
            {
                return new USDCoin(0.5M, Volume.HalfDollar);
            }
        }

        public static USDCoin Dollar
        {
            get
            {
                return new USDCoin(1M, Volume.Dollar);
            }
        }
    }
}
