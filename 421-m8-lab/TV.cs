using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class TV
    {
        private int price = 200;
        private string type = "Regular";
        private Dictionary<string, string> hm = new Dictionary<string, string>();
        public TV()
        {
            using (StreamReader reader = new StreamReader("D:\\SWENG 421Projects\\421-m8-lab\\421-m8-lab\\pricesheet.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] sa = line.Split(',');

                    hm[sa[0]] = sa[1]; // sa[0] is the key and sa[1] is the value.
                    
                }
            }
        }
        public TV ReplenishTV(int budget)
        {
            string closestKey = null;
            int closestDifference = int.MaxValue; // Initialize to a large value.

            foreach (var key in hm.Keys)
            {
                if (int.TryParse(key, out int keyValue))
                {
                    int priceDifference = budget - keyValue;

                    if (priceDifference >= 0 && priceDifference < closestDifference)
                    {
                        closestKey = key;
                        closestDifference = priceDifference;
                    }
                }
            }
            if (closestKey != null)
            {
                Type t = Type.GetType("TVSystem." + hm[closestKey]);
                Object o = Activator.CreateInstance(t);
                TV tv = (TV)o;
                return tv;
            }
            return null;
        }

        internal void SetPrice(int price)
        {
            this.price = price;
        }
        public virtual string GetInfo()
        {
            return "Price: $" + GetPrice()+ " Type: "+GetTypeTV(); 
        }

       internal int GetPrice() 
        {
            return price;
        }

        internal string GetTypeTV()
        {
            return type;
        }

        //not sure about adding this
        internal void SetType(string type)
        {
            this.type = type;
        }

    }
}
