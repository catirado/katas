namespace GildedRose.Quality
{
    internal class AgedBrieQualityUpdater : ItemQualityUpdater
    {
        private const int EXPIRED_QUALITY_INCREASE = DEFAULT_QUALITY_INCREASE * 2;

        public override void UpdateQuality(Item item)
        {
            IncreaseQualityBy(item, 
                SellDateHasPassed(item) ? 
                    EXPIRED_QUALITY_INCREASE : 
                    DEFAULT_QUALITY_INCREASE);
        }
    }
}