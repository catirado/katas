namespace GildedRose.Quality
{
    public class ConjuredQualityUpdater : ItemQualityUpdater
    {
        private const int TWICE_AS_FAST_QUALITY_DECREASE = DEFAULT_QUALITY_DECREASE * 2;

        public override void UpdateQuality(Item item)
        {
            DecreaseQualityBy(item,TWICE_AS_FAST_QUALITY_DECREASE);
        }
    }
}