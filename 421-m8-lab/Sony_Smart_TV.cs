/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* Sony_Smart_TV 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Sony_Smart_TV: Sony_TV, Smart_TVIF
    {
        private Smart_TV st = new Smart_TV();
        public Sony_Smart_TV(): base()
        {
            st.SetPrice(380);
            st.SetPowerUsage(5.15);
        }

        public override string GetInfo()
        {
            return st.GetInfo() + " Brand: " + GetBrand(); 
        }
    }
}

