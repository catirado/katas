namespace GildedRose.Quality
{
    internal class AgedBrieQualityUpdater : ItemQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            IncreaseQualityBy(item, 1);

            if (item.SellIn <= 0)
            {
                IncreaseQualityBy(item,1);
            }
        }
    }
}