using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class TV : TVIF
    {
        private int price;
        private string type;
        private string brand;

        public TV()
        {
            this.SetBrand("Unknown");
            this.SetType("Base Model");
            // "the default prices are $200 for TV"
            this.SetPrice(200);
        }

        public TV ReplenishTV(int budget)
        {
            return null;    //fix later
        }

        /*public string GetInfo()
        {
            return " "; // fix later
        }*/

        public void GetInfo()
        {
            Console.WriteLine("Price: $" + this.GetPrice());
            Console.WriteLine("Type: " + this.GetTypeTV());
            Console.WriteLine("Brand: " + this.GetBrand());
        }

        internal int GetPrice() 
        {
            return price;
        }

        internal void SetPrice(int price)
        {
            this.price = price;
        }

        // can't name method GetType() as its used to get Class names 
        internal string GetTypeTV()
        {
            return type;
        }

        internal void SetType(string type)
        {
            this.type = type;
        }

        internal string GetBrand()
        {
            return this.brand;
        }

        internal void SetBrand(string brand)
        {
            this.brand = brand;
        }

    }
}
