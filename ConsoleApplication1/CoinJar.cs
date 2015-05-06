using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoinJar
{
    public class CoinJar : AssetContainer
    {

        public CoinJar() : base(32)
        {
            
        }

        public CoinJar(decimal volume, Boolean isMultiCurrency) : base(volume, isMultiCurrency, "USD")
        {
        }

        public override void Insert(Asset asset)
        {
            if (asset == null) return;
            if (!asset.GetType().IsSubclassOf(typeof(Coin)))
            {
                throw new Exception("This jar only accept coin");
            }
            if (!isMultiCurrency && asset.GetType() != typeof(USDCoin))
            {
                throw new Exception("This jar only accept US coinage.");
            }
            if (decimal.Subtract(volumeRemaining, ((Coin)asset).volume) < 0)
            {
                throw new Exception("This jar is full.");
            }
            assets.Add(asset);
            volumeRemaining -= ((Coin)asset).volume;
            currency += CurrencyConverter.convert(asset, currencyCode);
        }
    }
}
