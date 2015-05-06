using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public abstract class AssetContainer : Asset
    {
        protected readonly decimal volume;
        protected decimal volumeRemaining { get; set; }
        protected Boolean isMultiCurrency { get; set; }
        protected List<Asset> assets;

        public AssetContainer(decimal volume)
            : this(volume, false, "USD")
        {
            Clear();
        }

        public AssetContainer(decimal volume, Boolean isMultiCurrency, string currencyCode)
            : base(currencyCode, 0)
        {
            if (volume < 0)
            {
                throw new Exception("The volume of the container is less than 0");
            }
            this.volume = volume;
            this.isMultiCurrency = isMultiCurrency;
            Clear();
        }

        public abstract void Insert(Asset asset);

        public void Clear()
        {
            volumeRemaining = volume;
            assets = new List<Asset>();
            currency = 0;
        }
    }
}
