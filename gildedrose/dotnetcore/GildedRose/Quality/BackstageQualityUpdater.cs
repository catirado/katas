namespace GildedRose.Quality
{
    public class BackstageQualityUpdater : ItemQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                    if (item.Quality < 50)
                        item.Quality = item.Quality + 1;

                if (item.SellIn < 6)
                    if (item.Quality < 50)
                        item.Quality = item.Quality + 1;
            }

            if (item.SellIn <= 0) item.Quality = 0;
        }
    }
}