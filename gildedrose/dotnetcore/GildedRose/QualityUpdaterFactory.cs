namespace GildedRose
{
    public class QualityUpdaterFactory
    {
        private const string AGED_BRIE_NAME = "Aged Brie";
        private const string BACKSTAGE_NAME = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS_NAME = "Sulfuras, Hand of Ragnaros";

        public QualityUpdaterFactory()
        {
            
        }
        
        public void Execute(Item item)
        {
            switch (item.Name)
            {
                case AGED_BRIE_NAME:
                {
                    var updater = new AgedBrieUpdater();
                    updater.update(item);
                    break;
                }
                case BACKSTAGE_NAME:
                {
                    ProcessBackstage(item);
                    break;
                }
                case SULFURAS_NAME:
                    ProcessSulfuras(item);
                    break;
                default:
                {
                    ProcessNormal(item);
                    break;
                }
            }
        }

        private void ProcessNormal(Item item)
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

        private void ProcessSulfuras(Item item)
        {
            //do nothing
        }

        private void ProcessBackstage(Item item)
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
    }
}