using Xunit;
using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;

namespace GildedRose.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class gilded_rose_should
    {
        [Fact]
        public void update_quality()
        {
            var name = new List<string>() {"foo", "Aged Brie","Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros", "Conjured Mana Cake" };
            var sellIn = new List<int>() {-1, 0, 5, 6, 7, 10, 11, 12};
            var quality = new List<int>() {-1, 0, 1, 2, 49, 50, 51};
            
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