using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace GildedRose.Tests
{
    public class gilded_rose_should
    {
        private static int EXPIRED = -1;
        
        [Fact]
        public void decrease_by_one_the_quality_of_normal_items()
        {
            var normalItem = Builder.Item.WithName("foo")
                .WithQuality(1)
                .Build();

            var items = new List<Item>() {normalItem};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            normalItem.Quality.Should().Be(0);
        }

        [Fact]
        public void decrease_by_one_the_sell_in_of_normal_items()
        {
            var genericItem = Builder.Item.WithName("foo")
                .WithSellIn(1)
                .Build();

            var items = new List<Item>() {genericItem};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            genericItem.SellIn.Should().Be(0);
        }

        [Fact]
        public void decrease_the_quality_of_normal_items_as_twice_as_fast_when_the_sell_date_has_passed()
        {
            var normalItem = Builder.Item.WithName("foo")
                .WithQuality(2)
                .WithSellIn(EXPIRED)
                .Build();

            var items = new List<Item>() {normalItem};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            normalItem.Quality.Should().Be(0);
        }

        [Fact]
        public void not_allow_that_the_quality_on_an_item_will_be_negative()
        {
            var normalItem = Builder.Item.WithName("foo")
                .WithQuality(0)
                .Build();
            
            var items = new List<Item>() {normalItem};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            normalItem.Quality.Should().Be(0);
        }

        [Fact]
        public void increase_the_quality_of_aged_brie_in_one_when_its_gets_older()
        {
            var agedBrie = Builder.Item.WithName("Aged Brie")
                .WithQuality(49)
                .Build();
            
            var items = new List<Item>() {agedBrie};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            agedBrie.Quality.Should().Be(50);
        }

        [Fact]
        public void not_increase_the_quality_of_aged_brie_more_than_fifty()
        {
            var agedBrie = Builder.Item.WithName("Aged Brie")
                .WithQuality(50)
                .Build();
            
            var items = new List<Item>() {agedBrie};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            agedBrie.Quality.Should().Be(50);
        }

        [Fact]
        public void not_change_the_sell_in_of_sulfuras()
        {
            var sulfuras = Builder.Item.WithName("Sulfuras, Hand of Ragnaros")
                .WithSellIn(1)
                .Build();
            
            var items = new List<Item>() {sulfuras};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            sulfuras.SellIn.Should().Be(1);
        }
        
        [Fact]
        public void not_change_the_quality_of_sulfuras()
        {
            var sulfuras = Builder.Item.WithName("Sulfuras, Hand of Ragnaros")
                .WithQuality(1)
                .Build();
            
            var items = new List<Item>() {sulfuras};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            sulfuras.Quality.Should().Be(1);
        }
        
        [Fact]
        public void increase_the_quality_of_backstage_in_one_when_concert_is_more_than_ten_days_away()
        {
            var backstage = Builder.Item.WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(1)
                .WithSellIn(11)
                .Build();

            var items = new List<Item>() {backstage};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            backstage.Quality.Should().Be(2);
        }
        
        [Fact]
        public void increase_the_quality_of_backstage_in_two_when_concert_is_more_than_six_days_away()
        {
            var backstage = Builder.Item.WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(1)
                .WithSellIn(6)
                .Build();

            var items = new List<Item>() {backstage};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            backstage.Quality.Should().Be(3);
        }
        
        [Fact]
        public void increase_the_quality_of_backstage_in_three_when_concert_is_less_than_five_days()
        {
            var backstage = Builder.Item.WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(1)
                .WithSellIn(5)
                .Build();

            var items = new List<Item>() {backstage};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            backstage.Quality.Should().Be(4);
        }
        
        [Fact]
        public void decrease_the_quality_of_backstage_to_zero_when_the_concert_has_passed()
        {
            var backstage = Builder.Item.WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(1)
                .WithSellIn(0)
                .Build();

            var items = new List<Item>() {backstage};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            backstage.Quality.Should().Be(0);
        }
        
        [Fact]
        public void not_increase_the_quality_of_an_backstage_more_than_fifty()
        {
            var backstage = Builder.Item.WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(50)
                .Build();
            
            var items = new List<Item>() {backstage};
            
            var gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            backstage.Quality.Should().Be(50);
        }
    }
}