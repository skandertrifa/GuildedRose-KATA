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
                var item = Items[i];
                ProcessItem(item);
            }
        }

        private void ProcessItem(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                if (item.Quality < 50)
                {
                    DecreaseSellIn(item);

                    IncreaseQuality(item);

                    if (item.SellIn < 0)
                    {
                        if (item.Quality < 50)
                        {
                            IncreaseQuality(item);
                        }
                    }
                }
                else
                {
                    DecreaseSellIn(item);
                }
            }
            else
            {
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Quality < 50)
                    {
                        IncreaseQuality(item);

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 2;
                            }
                        }
                        else
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    IncreaseQuality(item);
                                }
                            }
                        }

                        DecreaseSellIn(item);

                        if (item.SellIn < 0)
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        DecreaseSellIn(item);
                        if (item.SellIn < 0)
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                }
                else
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        if (item.Quality > 0)
                        {
                            DecreaseQuality(item);

                            DecreaseSellIn(item);

                            if (item.SellIn < 0)
                            {
                                if (item.Quality > 0)
                                {
                                    DecreaseQuality(item);
                                }
                            }
                        }
                        else
                        {
                            DecreaseSellIn(item);
                        }
                    }
                }
            }
        }

        private void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }

        private void IncreaseQuality(Item item)
        {
            item.Quality++;
        }
        
        private void DecreaseQuality(Item item)
        {
            item.Quality--;
        }
    }
}