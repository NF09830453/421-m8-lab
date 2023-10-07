/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* Proxy_TV 
* - connects the no brand TV hiearchy with the TV brand hiearchy 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Proxy_TV: TV, TVIF
    {
        TVIF tvif;
        TV tv; 
        public Proxy_TV(): base() 
        {

        }
        public override string GetInfo()
        {
            if (this.tv == null)
            {
                return this.GetInfo();
            }
            else
            {
                return this.tv.GetInfo();
            }
        }

        public TV ReplenishTV(int budget)
        {
            switch (budget)
            {
                case >= 480:
                    return new Sony_UltraHD_TV();
                case >= 450:
                    return new Vizio_UltraHD_TV();
                case >= 400:
                    return new UltraHD_TV();
                case >= 380:
                    return new Sony_Smart_TV();
                case >= 350:
                    return new Vizio_Smart_TV();
                case >= 300:
                    return new Smart_TV();
                case >= 280:
                    return new Sony_TV();
                case >= 250:
                    return new Vizio_TV();
                case >= 200:
                    return new TV();
                default:
                    return null;
            }
        }
    }
}
