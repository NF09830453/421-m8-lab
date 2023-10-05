using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class TV_Proxy: TV, TVIF
    {
        TVIF tv;
        //TV tv; 

        public TV_Proxy()
        {

        }

        public TV_Proxy(TVIF tv)
        {
            this.tv = tv;
        }

        public void GetInfo()
        {
            if (this.tv == null)
            {
                this.GetInfo();
            }
            else
            {
                this.tv.GetInfo();
            }
        }
    }
}
