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
            var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            string itemString = items[0].Name;
            Approvals.Verify(itemString);
        }
    }
}