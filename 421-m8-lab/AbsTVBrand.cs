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
