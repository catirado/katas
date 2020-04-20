namespace GildedRose.Tests
{
    public static class ItemExtensions
    {
        public static string ToDescription(this Item item)
        {
            return $"{item.Name}, {item.SellIn}, {item.Quality}";
        }
    }
}