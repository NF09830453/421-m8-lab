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

    }
}
