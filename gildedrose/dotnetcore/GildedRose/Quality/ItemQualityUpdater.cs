using System;

namespace GildedRose.Quality
{
    public abstract class ItemQualityUpdater
    {
        private const int ONE_SELL_ITEM_DECREASE = 1;
        private const int MAX_QUALITY = 50;
        private const int MIN_QUALITY = 0;
        
        public abstract void UpdateQuality(Item item);

        public virtual void UpdateSellIn(Item item)
        {
            DecreaseOneSellIn(item);
        }
        
        protected void IncreaseQualityBy(Item item, int increased)
        {
            int newQuality = Math.Min(item.Quality + increased, MAX_QUALITY);
            item.Quality = newQuality;
        }
        
        protected void DecreaseQualityBy(Item item, int increased)
        {
            if (item.Quality > MIN_QUALITY)
            {
                item.Quality -= increased;
            }
        }

        private void DecreaseOneSellIn(Item item)
        {
            item.SellIn -= ONE_SELL_ITEM_DECREASE;
        }
    }
}