namespace GildedRose
{
    public class QualityUpdaterFactory
    {
        public static void Execute(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                {
                    ProcessAgedBrie(item);
                    break;
                }
                case "Backstage passes to a TAFKAL80ETC concert":
                {
                    ProcessBackstage(item);
                    break;
                }
                case "Sulfuras, Hand of Ragnaros":
                    ProcessSulfuras(item);
                    break;
                default:
                {
                    ProcessNormal(item);
                    break;
                }
            }
        }

        private static void ProcessNormal(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }

        private static void ProcessSulfuras(Item item)
        {
            //do nothing
        }

        private static void ProcessBackstage(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        private static void ProcessAgedBrie(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}