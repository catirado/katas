using Xunit;
using System.Collections.Generic;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;

namespace GildedRose.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseApprovalTest
    {
        [Fact]
        public void UpdateQuality()
        {
            var name = new List<string>() {"foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros"};
            var sellIn = new List<int>() {-1, 0, 2, 6, 11};
            var quality = new List<int>() {0, 49, 50};
            
            CombinationApprovals.VerifyAllCombinations(
                ExecuteUpdateQuality,
                name,
                sellIn,
                quality);
        }

        private string ExecuteUpdateQuality(string name, int sellIn, int quality)
        {
            var items = new List<Item> {new Item {Name = name, SellIn = sellIn, Quality = quality}};
            var app = new GildedRose(items);
            app.UpdateQuality();
            return items[0].ToString();
        }
    }
}