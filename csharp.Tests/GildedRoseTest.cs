using NUnit.Framework;
using System.Diagnostics.Metrics;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }

        [Test]
        public void TestAgedBrieQuality()
        {
            IList<Item> Items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 0, Quality = -1 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = 1, Quality = -1 },
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = 5, Quality = -1 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = 6, Quality = -1 },
                new Item { Name = "Aged Brie", SellIn = 6, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 6, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 6, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 6, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 6, Quality = 100 },
                
                new Item { Name = "Aged Brie", SellIn = 11, Quality = -1 },
                new Item { Name = "Aged Brie", SellIn = 11, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 11, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 11, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 11, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 11, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = 12, Quality = -1 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 100 },

            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var counter = 0;
            // SELL IN 0
            var agedBrieWithNegativeQuality = Items[counter];
            Assert.AreEqual(-1, agedBrieWithNegativeQuality.SellIn);
            Assert.AreEqual(1, agedBrieWithNegativeQuality.Quality);

            var agedBrieWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(-1, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(2, agedBrieWithLessThan50Quality.Quality);

            var agedBrieWith10Quality = Items[++counter];
            Assert.AreEqual(-1, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(12, agedBrieWith10Quality.Quality);

            var agedBrieWith49Quality = Items[++counter];
            Assert.AreEqual(-1, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            var agedBrieWith50Quality = Items[++counter];
            Assert.AreEqual(-1, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            var agedBrieWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(-1, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

            // SELL IN 1
            agedBrieWithNegativeQuality = Items[++counter];
            Assert.AreEqual(0, agedBrieWithNegativeQuality.SellIn);
            Assert.AreEqual(0, agedBrieWithNegativeQuality.Quality);
            
            agedBrieWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(0, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[++counter];
            Assert.AreEqual(0, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[++counter];
            Assert.AreEqual(0, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[++counter];
            Assert.AreEqual(0, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);
            
            agedBrieWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(0, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

            // SELL IN 5
            agedBrieWithNegativeQuality = Items[++counter];
            Assert.AreEqual(4, agedBrieWithNegativeQuality.SellIn);
            Assert.AreEqual(0, agedBrieWithNegativeQuality.Quality);

            agedBrieWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(4, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[++counter];
            Assert.AreEqual(4, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[++counter];
            Assert.AreEqual(4, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[++counter];
            Assert.AreEqual(4, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            agedBrieWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(4, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

            // SELL IN 6
            agedBrieWithNegativeQuality = Items[++counter];
            Assert.AreEqual(5, agedBrieWithNegativeQuality.SellIn);
            Assert.AreEqual(0, agedBrieWithNegativeQuality.Quality);

            agedBrieWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(5, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[++counter];
            Assert.AreEqual(5, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[++counter];
            Assert.AreEqual(5, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[++counter];
            Assert.AreEqual(5, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            agedBrieWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(5, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);


            // SELL IN 11
            agedBrieWithNegativeQuality = Items[++counter];
            Assert.AreEqual(10, agedBrieWithNegativeQuality.SellIn);
            Assert.AreEqual(0, agedBrieWithNegativeQuality.Quality);

            agedBrieWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(10, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[++counter];
            Assert.AreEqual(10, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[++counter];
            Assert.AreEqual(10, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[++counter];
            Assert.AreEqual(10, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            agedBrieWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(10, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

            // SELL IN 12
            agedBrieWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(11, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, agedBrieWithLessThan50Quality.Quality);

            agedBrieWithNegativeQuality = Items[++counter];
            Assert.AreEqual(11, agedBrieWithNegativeQuality.SellIn);
            Assert.AreEqual(1, agedBrieWithNegativeQuality.Quality);

            agedBrieWith10Quality = Items[++counter];
            Assert.AreEqual(11, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[++counter];
            Assert.AreEqual(11, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[++counter];
            Assert.AreEqual(11, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            agedBrieWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(11, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

        }

        [Test]
        public void TestBackstagePassesQuality()
        {
            IList<Item> Items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = -1 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 100 },

                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = -1 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 10 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 50 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 100 },

                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = -1 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 50 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 100 },

                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = -1 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 50 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 100 },
                
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = -1 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 50 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 100 },

                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = -1 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 10 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 50 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 100 },

            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            // SELL IN 0
            var counter = 0;
            var backstagePassesWithNegativeQuality = Items[counter];
            Assert.AreEqual(-1, backstagePassesWithNegativeQuality.SellIn);
            Assert.AreEqual(0, backstagePassesWithNegativeQuality.Quality);
            
            var backstagePassesWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(-1, backstagePassesWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWithLessThan50Quality.Quality);

            var backstagePassesWith10Quality = Items[++counter];
            Assert.AreEqual(-1, backstagePassesWith10Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWith10Quality.Quality);

            var backstagePassesWith49Quality = Items[++counter];
            Assert.AreEqual(-1, backstagePassesWith49Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWith49Quality.Quality);

            var backstagePassesWith50Quality = Items[++counter];
            Assert.AreEqual(-1, backstagePassesWith50Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWith50Quality.Quality);

            var backstagePassesWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(-1, backstagePassesWithMoreThan50Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWithMoreThan50Quality.Quality);

            // SELL IN -1
            backstagePassesWithNegativeQuality = Items[++counter];
            Assert.AreEqual(-2, backstagePassesWithNegativeQuality.SellIn);
            Assert.AreEqual(0, backstagePassesWithNegativeQuality.Quality);
            
            backstagePassesWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(-2, backstagePassesWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWithLessThan50Quality.Quality);

            backstagePassesWith10Quality = Items[++counter];
            Assert.AreEqual(-2, backstagePassesWith10Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWith10Quality.Quality);

            backstagePassesWith49Quality = Items[++counter];
            Assert.AreEqual(-2, backstagePassesWith49Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWith49Quality.Quality);

            backstagePassesWith50Quality = Items[++counter];
            Assert.AreEqual(-2, backstagePassesWith50Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWith50Quality.Quality);

            backstagePassesWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(-2, backstagePassesWithMoreThan50Quality.SellIn);
            Assert.AreEqual(0, backstagePassesWithMoreThan50Quality.Quality);

            // SELL IN 5
            backstagePassesWithNegativeQuality = Items[++counter];
            Assert.AreEqual(4, backstagePassesWithNegativeQuality.SellIn);
            Assert.AreEqual(2, backstagePassesWithNegativeQuality.Quality);
            
            backstagePassesWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(4, backstagePassesWithLessThan50Quality.SellIn);
            Assert.AreEqual(3, backstagePassesWithLessThan50Quality.Quality);

            backstagePassesWith10Quality = Items[++counter];
            Assert.AreEqual(4, backstagePassesWith10Quality.SellIn);
            Assert.AreEqual(13, backstagePassesWith10Quality.Quality);

            backstagePassesWith49Quality = Items[++counter];
            Assert.AreEqual(4, backstagePassesWith49Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith49Quality.Quality);

            backstagePassesWith50Quality = Items[++counter];
            Assert.AreEqual(4, backstagePassesWith50Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith50Quality.Quality);

            backstagePassesWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(4, backstagePassesWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, backstagePassesWithMoreThan50Quality.Quality);

            // SELL IN 6
            backstagePassesWithNegativeQuality = Items[++counter];
            Assert.AreEqual(5, backstagePassesWithNegativeQuality.SellIn);
            Assert.AreEqual(1, backstagePassesWithNegativeQuality.Quality);

            backstagePassesWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(5, backstagePassesWithLessThan50Quality.SellIn);
            Assert.AreEqual(2, backstagePassesWithLessThan50Quality.Quality);

            backstagePassesWith10Quality = Items[++counter];
            Assert.AreEqual(5, backstagePassesWith10Quality.SellIn);
            Assert.AreEqual(12, backstagePassesWith10Quality.Quality);

            backstagePassesWith49Quality = Items[++counter];
            Assert.AreEqual(5, backstagePassesWith49Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith49Quality.Quality);

            backstagePassesWith50Quality = Items[++counter];
            Assert.AreEqual(5, backstagePassesWith50Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith50Quality.Quality);

            backstagePassesWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(5, backstagePassesWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, backstagePassesWithMoreThan50Quality.Quality);

            // SELL IN 11
            backstagePassesWithNegativeQuality = Items[++counter];
            Assert.AreEqual(10, backstagePassesWithNegativeQuality.SellIn);
            Assert.AreEqual(0, backstagePassesWithNegativeQuality.Quality);

            backstagePassesWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(10, backstagePassesWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, backstagePassesWithLessThan50Quality.Quality);

            backstagePassesWith10Quality = Items[++counter];
            Assert.AreEqual(10, backstagePassesWith10Quality.SellIn);
            Assert.AreEqual(11, backstagePassesWith10Quality.Quality);

            backstagePassesWith49Quality = Items[++counter];
            Assert.AreEqual(10, backstagePassesWith49Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith49Quality.Quality);

            backstagePassesWith50Quality = Items[++counter];
            Assert.AreEqual(10, backstagePassesWith50Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith50Quality.Quality);

            backstagePassesWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(10, backstagePassesWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, backstagePassesWithMoreThan50Quality.Quality);

            // SELL IN 12
            backstagePassesWithNegativeQuality = Items[++counter];
            Assert.AreEqual(11, backstagePassesWithNegativeQuality.SellIn);
            Assert.AreEqual(0, backstagePassesWithNegativeQuality.Quality);

            backstagePassesWithLessThan50Quality = Items[++counter];
            Assert.AreEqual(11, backstagePassesWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, backstagePassesWithLessThan50Quality.Quality);

            backstagePassesWith10Quality = Items[++counter];
            Assert.AreEqual(11, backstagePassesWith10Quality.SellIn);
            Assert.AreEqual(11, backstagePassesWith10Quality.Quality);

            backstagePassesWith49Quality = Items[++counter];
            Assert.AreEqual(11, backstagePassesWith49Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith49Quality.Quality);

            backstagePassesWith50Quality = Items[++counter];
            Assert.AreEqual(11, backstagePassesWith50Quality.SellIn);
            Assert.AreEqual(50, backstagePassesWith50Quality.Quality);

            backstagePassesWithMoreThan50Quality = Items[++counter];
            Assert.AreEqual(11, backstagePassesWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, backstagePassesWithMoreThan50Quality.Quality);
        }

        [Test]
        public void TestSulfurasHandOfRagnarosQuality()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = -1 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 0 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 10 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 49 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 50 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 100 },

                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = -1 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 0 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 10 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 49 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 50 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 100 },

                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = -1 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 0 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 10 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 49 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 50 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 100 },

                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = -1 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 0 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 49 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 50 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 100 },

                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 12, Quality = -1 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 12, Quality = 0 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 12, Quality = 10 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 12, Quality = 49 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 12, Quality = 50 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 12, Quality = 100 },

            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            // SELL IN 0
            var counter = 0;
            var sulfurasWithNegativeQuality = items[counter];
            Assert.AreEqual(0, sulfurasWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, sulfurasWithNegativeQuality.Quality);

             var sulfurasWithLessThan50Quality = items[++counter];
            Assert.AreEqual(0, sulfurasWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, sulfurasWithLessThan50Quality.Quality);

            var sulfurasWith10Quality = items[++counter];
            Assert.AreEqual(0, sulfurasWith10Quality.SellIn);
            Assert.AreEqual(10, sulfurasWith10Quality.Quality);

            var sulfurasWith49Quality = items[++counter];
            Assert.AreEqual(0, sulfurasWith49Quality.SellIn);
            Assert.AreEqual(49, sulfurasWith49Quality.Quality);

            var sulfurasWith50Quality = items[++counter];
            Assert.AreEqual(0, sulfurasWith50Quality.SellIn);
            Assert.AreEqual(50, sulfurasWith50Quality.Quality);

            var sulfurasWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(0, sulfurasWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, sulfurasWithMoreThan50Quality.Quality);

            // SELL IN -1
            sulfurasWithNegativeQuality = items[++counter];
            Assert.AreEqual(-1, sulfurasWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, sulfurasWithNegativeQuality.Quality);

            sulfurasWithLessThan50Quality = items[++counter];
            Assert.AreEqual(-1, sulfurasWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, sulfurasWithLessThan50Quality.Quality);

            sulfurasWith10Quality = items[++counter];
            Assert.AreEqual(-1, sulfurasWith10Quality.SellIn);
            Assert.AreEqual(10, sulfurasWith10Quality.Quality);

            sulfurasWith49Quality = items[++counter];
            Assert.AreEqual(-1, sulfurasWith49Quality.SellIn);
            Assert.AreEqual(49, sulfurasWith49Quality.Quality);

            sulfurasWith50Quality = items[++counter];
            Assert.AreEqual(-1, sulfurasWith50Quality.SellIn);
            Assert.AreEqual(50, sulfurasWith50Quality.Quality);

            sulfurasWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(-1, sulfurasWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, sulfurasWithMoreThan50Quality.Quality);

            // SELL IN 5
            sulfurasWithNegativeQuality = items[++counter];
            Assert.AreEqual(5, sulfurasWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, sulfurasWithNegativeQuality.Quality);

            sulfurasWithLessThan50Quality = items[++counter];
            Assert.AreEqual(5, sulfurasWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, sulfurasWithLessThan50Quality.Quality);

            sulfurasWith10Quality = items[++counter];
            Assert.AreEqual(5, sulfurasWith10Quality.SellIn);
            Assert.AreEqual(10, sulfurasWith10Quality.Quality);

            sulfurasWith49Quality = items[++counter];
            Assert.AreEqual(5, sulfurasWith49Quality.SellIn);
            Assert.AreEqual(49, sulfurasWith49Quality.Quality);

            sulfurasWith50Quality = items[++counter];
            Assert.AreEqual(5, sulfurasWith50Quality.SellIn);
            Assert.AreEqual(50, sulfurasWith50Quality.Quality);

            sulfurasWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(5, sulfurasWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, sulfurasWithMoreThan50Quality.Quality);

            // SELL IN 10
            sulfurasWithNegativeQuality = items[++counter];
            Assert.AreEqual(10, sulfurasWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, sulfurasWithNegativeQuality.Quality);

            sulfurasWithLessThan50Quality = items[++counter];
            Assert.AreEqual(10, sulfurasWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, sulfurasWithLessThan50Quality.Quality);

            sulfurasWith10Quality = items[++counter];
            Assert.AreEqual(10, sulfurasWith10Quality.SellIn);
            Assert.AreEqual(10, sulfurasWith10Quality.Quality);

            sulfurasWith49Quality = items[++counter];
            Assert.AreEqual(10, sulfurasWith49Quality.SellIn);
            Assert.AreEqual(49, sulfurasWith49Quality.Quality);

            sulfurasWith50Quality = items[++counter];
            Assert.AreEqual(10, sulfurasWith50Quality.SellIn);
            Assert.AreEqual(50, sulfurasWith50Quality.Quality);

            sulfurasWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(10, sulfurasWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, sulfurasWithMoreThan50Quality.Quality);

            // SELL IN 12
            sulfurasWithNegativeQuality = items[++counter];
            Assert.AreEqual(12, sulfurasWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, sulfurasWithNegativeQuality.Quality);

            sulfurasWithLessThan50Quality = items[++counter];
            Assert.AreEqual(12, sulfurasWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, sulfurasWithLessThan50Quality.Quality);

            sulfurasWith10Quality = items[++counter];
            Assert.AreEqual(12, sulfurasWith10Quality.SellIn);
            Assert.AreEqual(10, sulfurasWith10Quality.Quality);

            sulfurasWith49Quality = items[++counter];
            Assert.AreEqual(12, sulfurasWith49Quality.SellIn);
            Assert.AreEqual(49, sulfurasWith49Quality.Quality);

            sulfurasWith50Quality = items[++counter];
            Assert.AreEqual(12, sulfurasWith50Quality.SellIn);
            Assert.AreEqual(50, sulfurasWith50Quality.Quality);

            sulfurasWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(12, sulfurasWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, sulfurasWithMoreThan50Quality.Quality);
        }

        [Test]
        public void TestUnknownNameQuality()
        {
            var name = "Blabla";
            IList<Item> items = new List<Item>
            {
                new Item { Name = name, SellIn = 0, Quality = -1 },
                new Item { Name = name, SellIn = 0, Quality = 0 },
                new Item { Name = name, SellIn = 0, Quality = 10 },
                new Item { Name = name, SellIn = 0, Quality = 49 },
                new Item { Name = name, SellIn = 0, Quality = 50 },
                new Item { Name = name, SellIn = 0, Quality = 100 },

                new Item { Name = name, SellIn = -1, Quality = -1 },
                new Item { Name = name, SellIn = -1, Quality = 0 },
                new Item { Name = name, SellIn = -1, Quality = 10 },
                new Item { Name = name, SellIn = -1, Quality = 49 },
                new Item { Name = name, SellIn = -1, Quality = 50 },
                new Item { Name = name, SellIn = -1, Quality = 100 },

                new Item { Name = name, SellIn = 5, Quality = -1 },
                new Item { Name = name, SellIn = 5, Quality = 0 },
                new Item { Name = name, SellIn = 5, Quality = 10 },
                new Item { Name = name, SellIn = 5, Quality = 49 },
                new Item { Name = name, SellIn = 5, Quality = 50 },
                new Item { Name = name, SellIn = 5, Quality = 100 },

                new Item { Name = name, SellIn = 10, Quality = -1 },
                new Item { Name = name, SellIn = 10, Quality = 0 },
                new Item { Name = name, SellIn = 10, Quality = 10 },
                new Item { Name = name, SellIn = 10, Quality = 49 },
                new Item { Name = name, SellIn = 10, Quality = 50 },
                new Item { Name = name, SellIn = 10, Quality = 100 },

                new Item { Name = name, SellIn = 12, Quality = -1 },
                new Item { Name = name, SellIn = 12, Quality = 0 },
                new Item { Name = name, SellIn = 12, Quality = 10 },
                new Item { Name = name, SellIn = 12, Quality = 49 },
                new Item { Name = name, SellIn = 12, Quality = 50 },
                new Item { Name = name, SellIn = 12, Quality = 100 },

            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            var counter = 0;

            // SELL IN 0
            var unknownNameWithNegativeQuality = items[counter];
            Assert.AreEqual(-1, unknownNameWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, unknownNameWithNegativeQuality.Quality);

            var unknownNameWithLessThan50Quality = items[++counter];
            Assert.AreEqual(-1, unknownNameWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, unknownNameWithLessThan50Quality.Quality);

            var unknownNameWith10Quality = items[++counter];
            Assert.AreEqual(-1, unknownNameWith10Quality.SellIn);
            Assert.AreEqual(8, unknownNameWith10Quality.Quality);

            var unknownNameWith49Quality = items[++counter];
            Assert.AreEqual(-1, unknownNameWith49Quality.SellIn);
            Assert.AreEqual(47, unknownNameWith49Quality.Quality);

            var unknownNameWith50Quality = items[++counter];
            Assert.AreEqual(-1, unknownNameWith50Quality.SellIn);
            Assert.AreEqual(48, unknownNameWith50Quality.Quality);

            var unknownNameWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(-1, unknownNameWithMoreThan50Quality.SellIn);
            Assert.AreEqual(98, unknownNameWithMoreThan50Quality.Quality);

            // SELL IN -1
            unknownNameWithNegativeQuality = items[++counter];
            Assert.AreEqual(-2, unknownNameWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, unknownNameWithNegativeQuality.Quality);

            unknownNameWithLessThan50Quality = items[++counter];
            Assert.AreEqual(-2, unknownNameWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, unknownNameWithLessThan50Quality.Quality);

            unknownNameWith10Quality = items[++counter];
            Assert.AreEqual(-2, unknownNameWith10Quality.SellIn);
            Assert.AreEqual(8, unknownNameWith10Quality.Quality);

            unknownNameWith49Quality = items[++counter];
            Assert.AreEqual(-2, unknownNameWith49Quality.SellIn);
            Assert.AreEqual(47, unknownNameWith49Quality.Quality);

            unknownNameWith50Quality = items[++counter];
            Assert.AreEqual(-2, unknownNameWith50Quality.SellIn);
            Assert.AreEqual(48, unknownNameWith50Quality.Quality);

            unknownNameWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(-2, unknownNameWithMoreThan50Quality.SellIn);
            Assert.AreEqual(98, unknownNameWithMoreThan50Quality.Quality);

            // SELL IN 5
            unknownNameWithNegativeQuality = items[++counter];
            Assert.AreEqual(4, unknownNameWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, unknownNameWithNegativeQuality.Quality);

            unknownNameWithLessThan50Quality = items[++counter];
            Assert.AreEqual(4, unknownNameWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, unknownNameWithLessThan50Quality.Quality);

            unknownNameWith10Quality = items[++counter];
            Assert.AreEqual(4, unknownNameWith10Quality.SellIn);
            Assert.AreEqual(9, unknownNameWith10Quality.Quality);

            unknownNameWith49Quality = items[++counter];
            Assert.AreEqual(4, unknownNameWith49Quality.SellIn);
            Assert.AreEqual(48, unknownNameWith49Quality.Quality);

            unknownNameWith50Quality = items[++counter];
            Assert.AreEqual(4, unknownNameWith50Quality.SellIn);
            Assert.AreEqual(49, unknownNameWith50Quality.Quality);

            unknownNameWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(4, unknownNameWithMoreThan50Quality.SellIn);
            Assert.AreEqual(99, unknownNameWithMoreThan50Quality.Quality);

            // SELL IN 10
            unknownNameWithNegativeQuality = items[++counter];
            Assert.AreEqual(9, unknownNameWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, unknownNameWithNegativeQuality.Quality);

            unknownNameWithLessThan50Quality = items[++counter];
            Assert.AreEqual(9, unknownNameWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, unknownNameWithLessThan50Quality.Quality);

            unknownNameWith10Quality = items[++counter];
            Assert.AreEqual(9, unknownNameWith10Quality.SellIn);
            Assert.AreEqual(9, unknownNameWith10Quality.Quality);

            unknownNameWith49Quality = items[++counter];
            Assert.AreEqual(9, unknownNameWith49Quality.SellIn);
            Assert.AreEqual(48, unknownNameWith49Quality.Quality);

            unknownNameWith50Quality = items[++counter];
            Assert.AreEqual(9, unknownNameWith50Quality.SellIn);
            Assert.AreEqual(49, unknownNameWith50Quality.Quality);

            unknownNameWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(9, unknownNameWithMoreThan50Quality.SellIn);
            Assert.AreEqual(99, unknownNameWithMoreThan50Quality.Quality);

            // SELL IN 12
            unknownNameWithNegativeQuality = items[++counter];
            Assert.AreEqual(11, unknownNameWithNegativeQuality.SellIn);
            Assert.AreEqual(-1, unknownNameWithNegativeQuality.Quality);

            unknownNameWithLessThan50Quality = items[++counter];
            Assert.AreEqual(11, unknownNameWithLessThan50Quality.SellIn);
            Assert.AreEqual(0, unknownNameWithLessThan50Quality.Quality);

            unknownNameWith10Quality = items[++counter];
            Assert.AreEqual(11, unknownNameWith10Quality.SellIn);
            Assert.AreEqual(9, unknownNameWith10Quality.Quality);

            unknownNameWith49Quality = items[++counter];
            Assert.AreEqual(11, unknownNameWith49Quality.SellIn);
            Assert.AreEqual(48, unknownNameWith49Quality.Quality);

            unknownNameWith50Quality = items[++counter];
            Assert.AreEqual(11, unknownNameWith50Quality.SellIn);
            Assert.AreEqual(49, unknownNameWith50Quality.Quality);

            unknownNameWithMoreThan50Quality = items[++counter];
            Assert.AreEqual(11, unknownNameWithMoreThan50Quality.SellIn);
            Assert.AreEqual(99, unknownNameWithMoreThan50Quality.Quality);
        }
    }
}
