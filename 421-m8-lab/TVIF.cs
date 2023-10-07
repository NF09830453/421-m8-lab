/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* TV interface 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public interface TVIF
    {
        TV ReplenishTV(int budget);
        string GetInfo();
    }
}
