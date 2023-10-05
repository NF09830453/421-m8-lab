using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSystem;

namespace _421_m8_lab
{
    public class Smart_TVProxy : TV_Proxy, Smart_TVIF
    {
        private Smart_TVIF tv;

        public Smart_TVProxy(Smart_TVIF tv) : base(tv)
        {
            this.tv = tv;
        }

        public double GetPowerUsage()
        {
            return this.tv.GetPowerUsage();
        }
    }
}
