using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRefactorizada
{
    public class Item
    {
        public string Name { get; set; }

        private int SellIn { get; set; }

        private int Quality { get; set; }

        public Item(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }
        
        public void Update()
        {

            if (this.Name.Equals("Aged Brie"))
            {
                AgedBrieUpdate();
            }
            else if (this.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
            {
                BackstageUpdate();
            }
            else if (this.Name.Equals("Sulfuras, Hand of Ragnaros"))
            {
                SulfurasUpdate();
            }

            if (this.Quality > 50)
            {
                this.Quality = 50;
            }
        }

        private void SulfurasUpdate()
        {
            this.Quality += 1;
        }

        private void AgedBrieUpdate()
        {
            this.SellIn -= 1;

            if (IsValidQuality())
            {
                this.Quality += 1;
            }
        }

        private void BackstageUpdate()
        {
            this.SellIn -= 1;

            if (IsValidQuality())
            {
                if (this.SellIn < 6)
                {
                    this.Quality += 3;
                    return;
                }

                if (this.SellIn < 11)
                {
                    this.Quality += 2;
                }

                if (this.SellIn < 0)
                {
                    this.Quality -= this.Quality;
                }
            }            
        }

        private bool IsValidQuality()
        {
            return this.Quality > 0 && this.Quality < 50;
        }

        public override String ToString()
        {
            return string.Format("{0}, {1}, {2}", this.Name, this.SellIn, this.Quality);
        }
    }
}
