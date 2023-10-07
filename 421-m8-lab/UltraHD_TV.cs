/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* UltraHD_TV 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public sealed class UltraHD_TV: TV
    {
        public UltraHD_TV()
        {
            SetPrice(400);
            SetType("UltraHD");
        }
    }
}
