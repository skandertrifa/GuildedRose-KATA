using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var currentItem = Items[i];
                ProcessItem(currentItem);
            }
        }

        private void ProcessItem(Item currentItem)
        {
            if (currentItem.Name == "Age Brie")
            {
                var agedBrie = "Aged Brie";
                var backstagePassesToATafkal80etcConcert = "Backstage passes to a TAFKAL80ETC concert";
                var sulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

                if (currentItem.Quality < 50)
                {
                    currentItem.Quality = currentItem.Quality + 1;
                }

                if (currentItem.Name != sulfurasHandOfRagnaros)
                {
                    currentItem.SellIn = currentItem.SellIn - 1;
                }

                if (currentItem.SellIn < 0)
                {
                    if (currentItem.Quality < 50)
                    {
                        currentItem.Quality = currentItem.Quality + 1;
                    }
                }
            }
            else
            {
                var agedBrie = "Aged Brie";
                var backstagePassesToATafkal80etcConcert = "Backstage passes to a TAFKAL80ETC concert";
                var sulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

                if (currentItem.Name != backstagePassesToATafkal80etcConcert)
                {
                    if (currentItem.Quality > 0)
                    {
                        if (currentItem.Name != sulfurasHandOfRagnaros)
                        {
                            currentItem.Quality = currentItem.Quality - 1;
                        }
                    }
                }
                else
                {
                    if (currentItem.Quality < 50)
                    {
                        currentItem.Quality = currentItem.Quality + 1;

                        if (currentItem.Name == backstagePassesToATafkal80etcConcert)
                        {
                            if (currentItem.SellIn < 11)
                            {
                                if (currentItem.Quality < 50)
                                {
                                    currentItem.Quality = currentItem.Quality + 1;
                                }
                            }

                            if (currentItem.SellIn < 6)
                            {
                                if (currentItem.Quality < 50)
                                {
                                    currentItem.Quality = currentItem.Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (currentItem.Name != sulfurasHandOfRagnaros)
                {
                    currentItem.SellIn = currentItem.SellIn - 1;
                }

                if (currentItem.SellIn < 0)
                {
                    if (currentItem.Name != agedBrie)
                    {
                        if (currentItem.Name != backstagePassesToATafkal80etcConcert)
                        {
                            if (currentItem.Quality > 0)
                            {
                                if (currentItem.Name != sulfurasHandOfRagnaros)
                                {
                                    currentItem.Quality = currentItem.Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            currentItem.Quality = currentItem.Quality - currentItem.Quality;
                        }
                    }
                    else
                    {
                        if (currentItem.Quality < 50)
                        {
                            currentItem.Quality = currentItem.Quality + 1;
                        }
                    }
                }
            }
        }
    }
}