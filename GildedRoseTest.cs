using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
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
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = -1, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = -1, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = -1, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = -1, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = -1, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = 5, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 5, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = 10, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 10, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 10, Quality = 100 },

                new Item { Name = "Aged Brie", SellIn = 12, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 10 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 50 },
                new Item { Name = "Aged Brie", SellIn = 12, Quality = 100 },

            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            // SELL IN 0
            var agedBrieWithLessThan50Quality = Items[0];
            Assert.AreEqual(-1, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(2, agedBrieWithLessThan50Quality.Quality);

            var agedBrieWith10Quality = Items[1];
            Assert.AreEqual(-1, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(12, agedBrieWith10Quality.Quality);

            var agedBrieWith49Quality = Items[2];
            Assert.AreEqual(-1, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            var agedBrieWith50Quality = Items[3];
            Assert.AreEqual(-1, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            var agedBrieWithMoreThan50Quality = Items[4];
            Assert.AreEqual(-1, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

            // SELL IN -1
            agedBrieWithLessThan50Quality = Items[5];
            Assert.AreEqual(-2, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(2, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[6];
            Assert.AreEqual(-2, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(12, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[7];
            Assert.AreEqual(-2, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[8];
            Assert.AreEqual(-2, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);
            
            agedBrieWithMoreThan50Quality = Items[9];
            Assert.AreEqual(-2, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

            // SELL IN 5
            agedBrieWithLessThan50Quality = Items[10];
            Assert.AreEqual(4, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[11];
            Assert.AreEqual(4, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[12];
            Assert.AreEqual(4, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[13];
            Assert.AreEqual(4, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            agedBrieWithMoreThan50Quality = Items[14];
            Assert.AreEqual(4, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

            // SELL IN 10
            agedBrieWithLessThan50Quality = Items[15];
            Assert.AreEqual(9, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[16];
            Assert.AreEqual(9, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[17];
            Assert.AreEqual(9, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[18];
            Assert.AreEqual(9, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            agedBrieWithMoreThan50Quality = Items[19];
            Assert.AreEqual(9, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);
            
            // SELL IN 12
            agedBrieWithLessThan50Quality = Items[20];
            Assert.AreEqual(11, agedBrieWithLessThan50Quality.SellIn);
            Assert.AreEqual(1, agedBrieWithLessThan50Quality.Quality);

            agedBrieWith10Quality = Items[21];
            Assert.AreEqual(11, agedBrieWith10Quality.SellIn);
            Assert.AreEqual(11, agedBrieWith10Quality.Quality);

            agedBrieWith49Quality = Items[22];
            Assert.AreEqual(11, agedBrieWith49Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith49Quality.Quality);

            agedBrieWith50Quality = Items[23];
            Assert.AreEqual(11, agedBrieWith50Quality.SellIn);
            Assert.AreEqual(50, agedBrieWith50Quality.Quality);

            agedBrieWithMoreThan50Quality = Items[24];
            Assert.AreEqual(11, agedBrieWithMoreThan50Quality.SellIn);
            Assert.AreEqual(100, agedBrieWithMoreThan50Quality.Quality);

        }
    }
}
