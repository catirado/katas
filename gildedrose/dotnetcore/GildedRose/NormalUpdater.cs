namespace GildedRose
{
    public class NormalUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            if (item.SellIn <= 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }
    }
}