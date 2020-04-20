using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                executeUpdateQuality(item);
            }
        }

        private static void executeUpdateQuality(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
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

                    break;
                }
                case "Backstage passes to a TAFKAL80ETC concert":
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

                    break;
                }
                case "Sulfuras, Hand of Ragnaros":
                    break;
                default:
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

                    break;
                }
            }
        }
    }
}