using System.Collections.Generic;
using GildedRose.Quality;

namespace GildedRose
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                UpdateQuality(item);
            }
        }

        private static void UpdateQuality(Item item)
        {
            var updater = new QualityUpdaterFactory();
            updater.UpdateFor(item);
        }
    }
}