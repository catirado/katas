namespace GildedRose
{
    public class QualityUpdaterFactory
    {
        private const string AGED_BRIE_NAME = "Aged Brie";
        private const string BACKSTAGE_NAME = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS_NAME = "Sulfuras, Hand of Ragnaros";

        public void Execute(Item item)
        {
            IItemUpdater updater = item.Name switch
            {
                AGED_BRIE_NAME => new AgedBrieUpdater(),
                BACKSTAGE_NAME => new BackstageUpdater(),
                SULFURAS_NAME => new SulfurasUpdater(),
                _ => new NormalUpdater()
            };
            updater.Update(item);
        }
    }
}