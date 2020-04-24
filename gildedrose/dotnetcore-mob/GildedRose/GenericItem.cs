namespace GildedRose
{
    public class GenericItem : Item
    {
        public GenericItem(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public void Update()
        {
            if (Quality > 0)
            {
                Quality = Quality - 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality - 1;
                }
            }
        }
    }
}