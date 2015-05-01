using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoinJar
{
    class CADCoin : Coin
    {
        enum Volume
        { //volume in fl oz. * 10000
            Penny = 122,
            Nickel = 243,
            Dime = 115,
            Quarter = 270,
            HalfDollar = 534,
            Dollar = 800,
            Toonie = 1000
        };

        private CADCoin(decimal currency, Volume volume)
            : base("CAD", currency, (decimal)volume / 10000)
        {
        }

        public static CADCoin Penny
        {
            get
            {
                return new CADCoin(0.01M, Volume.Penny);
            }
        }

        public static CADCoin Nickel
        {
            get
            {
                return new CADCoin(0.05M, Volume.Nickel);
            }
        }

        public static CADCoin Dime
        {
            get
            {
                return new CADCoin(0.1M, Volume.Dime);
            }
        }

        public static CADCoin Quarter
        {
            get
            {
                return new CADCoin(0.25M, Volume.Quarter);
            }
        }

        public static CADCoin HalfDollar
        {
            get
            {
                return new CADCoin(0.5M, Volume.HalfDollar);
            }
        }

        public static CADCoin Dollar
        {
            get
            {
                return new CADCoin(1M, Volume.Dollar);
            }
        }

        public static CADCoin Toonie
        {
            get
            {
                return new CADCoin(2M, Volume.Toonie);
            }
        }
    }
}
