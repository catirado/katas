namespace GildedRose.Quality
{
    public class NormalQualityUpdater : ItemQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            DecreaseQualityBy(item, 1);
            
            if (item.SellIn <= 0)
            {
                DecreaseQualityBy(item, 1);
            }
        }
    }
}