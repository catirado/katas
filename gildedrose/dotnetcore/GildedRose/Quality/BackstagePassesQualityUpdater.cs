namespace GildedRose.Quality
{
    public class BackstagePassesQualityUpdater : ItemQualityUpdater
    {
        private const int FIVE_DAYS = 5;
        private const int ELEVEN_DAYS = 11;

        private const int DOUBLE_QUALITY_INCREASE = 2;
        private const int TRIPLE_QUALITY_INCREASE = 3;

        public override void UpdateQuality(Item item)
        {
            if (SellDateHasPassed(item))
            {
                SetQualityToZero(item);
            }
            else
            {
                IncreaseQualityBy(item, CalculateQualityIncrease(item));
            }
        }

        private int CalculateQualityIncrease(Item item)
        {
            if (ConcertIsBetweenSixAndTenDays(item))
            {
                return DOUBLE_QUALITY_INCREASE;
            }

            if (ConcertIsInFiveDaysOrLess(item))
            {
                return TRIPLE_QUALITY_INCREASE;
            }

            return DEFAULT_QUALITY_INCREASE;
        }

        private bool ConcertIsInFiveDaysOrLess(Item item)
        {
            return item.SellIn <= FIVE_DAYS;
        }

        private bool ConcertIsBetweenSixAndTenDays(Item item)
        {
            return item.SellIn > FIVE_DAYS && item.SellIn < ELEVEN_DAYS;
        }
    }
}