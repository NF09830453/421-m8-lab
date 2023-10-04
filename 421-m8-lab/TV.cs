using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class TV
    {
        private int price;
        private string type;

        internal void SetPrice(int price)
        {
            this.price = price;
        }
        public TV ReplenishTV(int budget)
        {
            return null;    //fix later
        }

        public string GetInfo()
        {
            return " "; // fix later
        }

        public int GetPrice() 
        {
            return price;
        }

        public string GetType()
        {
            return type;
        }

    }
}
