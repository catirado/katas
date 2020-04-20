namespace GildedRose.Quality
{
    internal class AgedBrieQualityUpdater : ItemQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50) item.Quality = item.Quality + 1;

            if (item.SellIn <= 0)
                if (item.Quality < 50)
                    item.Quality = item.Quality + 1;
        }
    }
}