namespace GildedRose
{
    public abstract class ItemUpdater
    {
        public abstract void UpdateQuality(Item item);

        public virtual void UpdateSellIn(Item item)
        {
            item.SellIn -= 1;
        }
    }
}