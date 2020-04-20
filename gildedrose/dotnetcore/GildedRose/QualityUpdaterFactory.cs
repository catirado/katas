namespace GildedRose
{
    public class QualityUpdaterFactory
    {
        private const string AGED_BRIE_NAME = "Aged Brie";
        private const string BACKSTAGE_NAME = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS_NAME = "Sulfuras, Hand of Ragnaros";

        public void Execute(Item item)
        {
            IItemUpdater updater;
            switch (item.Name)
            {
                case AGED_BRIE_NAME:
                {
                    updater = new AgedBrieUpdater();
                    break;
                }
                case BACKSTAGE_NAME:
                {
                    updater = new BackstageUpdater();
                    break;
                }
                case SULFURAS_NAME:
                    updater = new SulfurasUpdater();
                    break;
                default:
                {
                    updater = new NormalUpdater();
                    break;
                }
            }
            updater.Update(item);
        }

        private void ProcessNormal(Item item)
        {
            
        }
    }
}