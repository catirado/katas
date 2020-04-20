namespace GildedRose.Tests
{
    public class ItemBuilder
    {
        private string _name;
        private int _sellIn = 1;
        private int _quality = 1;
        
        public ItemBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        
        public ItemBuilder WithSellIn(int sellIn)
        {
            _sellIn = sellIn;
            return this;
        }
        
        public ItemBuilder WithQuality(int quality)
        {
            _quality = quality;
            return this;
        }

        public Item Build()
        {
            return new Item {Name = _name, SellIn = _sellIn, Quality = _quality};
        }
    }
}