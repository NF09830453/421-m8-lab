using System;
/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* Vizio_UltraHD_TV 
*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Vizio_UltraHD_TV: Vizio_TV, UltraHD_TVIF
    {
        public Vizio_UltraHD_TV() : base()
        {
            this.SetPrice(450);
            this.SetType("UltraHD");
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " Brand: " + GetBrand();
        }
    }
}
