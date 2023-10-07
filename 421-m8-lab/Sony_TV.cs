/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* Sony_TV
* - inherits from AbsTVBrand
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Sony_TV: AbsTVBrand
    {
        public Sony_TV()
        {
            this.SetPrice(280);
            this.SetBrand("Sony");
            this.SetType("Regular");
        }
    }
}
