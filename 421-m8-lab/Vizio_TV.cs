/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* Vizio_TV 
* - inherits from AbsTVBrand
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Vizio_TV: AbsTVBrand
    {
        public Vizio_TV()
        {
            this.SetPrice(250);
            this.SetBrand("Vizio");
            this.SetType("Regular"); 
        }
    }
}
