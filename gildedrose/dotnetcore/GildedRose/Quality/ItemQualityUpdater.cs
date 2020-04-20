using System;

namespace GildedRose.Quality
{
    public abstract class ItemQualityUpdater
    {
        private const int MAX_QUALITY = 50;
        private const int MIN_QUALITY = 0;
        protected const int DEFAULT_QUALITY_INCREASE = 1;
        protected const int DEFAULT_QUALITY_DECREASE = 1;
        private const int DEFAULT_SELL_ITEM_DECREASE = 1;
        
        public abstract void UpdateQuality(Item item);

        public virtual void UpdateSellIn(Item item)
        {
            DecreaseSellInByOne(item);
        }
        
        protected void IncreaseQualityBy(Item item, int increased)
        {
            item.Quality = Math.Min(item.Quality + increased, MAX_QUALITY);
        }
        
        protected void DecreaseQualityBy(Item item, int decreased)
        {
            item.Quality = Math.Max(item.Quality - decreased, MIN_QUALITY);
        }
        
        protected void SetQualityToZero(Item item)
        {
            item.Quality = 0;
        }

        private void DecreaseSellInByOne(Item item)
        {
            item.SellIn -= DEFAULT_SELL_ITEM_DECREASE;
        }

        protected bool SellDateHasPassed(Item item)
        {
            return item.SellIn <= 0;
        }
    }
}