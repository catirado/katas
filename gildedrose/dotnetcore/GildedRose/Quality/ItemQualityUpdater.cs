namespace GildedRose.Quality
{
    public abstract class ItemQualityUpdater
    {
        public abstract void UpdateQuality(Item item);

        public virtual void UpdateSellIn(Item item)
        {
            item.SellIn -= 1;
        }
    }
}