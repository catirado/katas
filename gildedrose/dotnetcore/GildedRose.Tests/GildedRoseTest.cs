using Xunit;
using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace GildedRose.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseTest
    {
        [Fact]
        public void updateQuantity()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            string itemString = items[0].Name.ToString();
            Approvals.Verify(itemString);
        }
    }
}