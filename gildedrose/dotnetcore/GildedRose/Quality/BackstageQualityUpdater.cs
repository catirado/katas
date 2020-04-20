namespace GildedRose.Quality
{
    public class BackstageQualityUpdater : ItemQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            IncreaseQualityBy(item, 1);

            if (item.SellIn < 11)
            {
                IncreaseQualityBy(item, 1);
            }

            if (item.SellIn < 6)
            {
                IncreaseQualityBy(item, 1);
            }

            if (item.SellIn <= 0)
            {
                SetQualityToZero(item);
            }
        }

        private static void SetQualityToZero(Item item)
        {
            item.Quality = 0;
        }
    }
}