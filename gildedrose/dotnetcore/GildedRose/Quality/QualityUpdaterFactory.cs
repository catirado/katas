namespace GildedRose.Quality
{
    public class QualityUpdaterFactory
    {
        private const string AGED_BRIE_NAME = "Aged Brie";
        private const string BACKSTAGE_NAME = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS_NAME = "Sulfuras, Hand of Ragnaros";

        public void UpdateFor(Item item)
        {
            ItemQualityUpdater qualityUpdater = item.Name switch
            {
                AGED_BRIE_NAME => new AgedBrieQualityUpdater(),
                BACKSTAGE_NAME => new BackstageQualityUpdater(),
                SULFURAS_NAME => new SulfurasQualityUpdater(),
                _ => new NormalQualityUpdater()
            };
            qualityUpdater.UpdateQuality(item);
            qualityUpdater.UpdateSellIn(item);
        }
    }
}