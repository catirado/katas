namespace GildedRose.Quality
{
    public class QualityUpdaterFactory
    {
        private const string AGED_BRIE_NAME = "Aged Brie";
        private const string BACKSTAGE_PASSES_NAME = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS_NAME = "Sulfuras, Hand of Ragnaros";

        public void UpdateFor(Item item)
        {
            ItemQualityUpdater qualityUpdater = item.Name switch
            {
                AGED_BRIE_NAME => new AgedBrieQualityUpdater(),
                BACKSTAGE_PASSES_NAME => new BackstagePassesQualityUpdater(),
                SULFURAS_NAME => new SulfurasQualityUpdater(),
                _ => new NormalQualityUpdater()
            };
            qualityUpdater.UpdateQuality(item);
            qualityUpdater.UpdateSellIn(item);
        }
    }
}