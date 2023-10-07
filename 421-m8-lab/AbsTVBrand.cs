/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* AbsTVBrand 
* - handles separate hierarchy of TV brands from regular TV class 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public abstract class AbsTVBrand: Proxy_TV, TVIF
    {
        private string brand;
        internal string GetBrand()
        {
            return brand;
        }
        internal void SetBrand(string brand)
        {
            this.brand = brand; 
        }

    }
}
