using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public abstract class AbsTVBrand: TVIF
    {
        private string brand;
        internal string GetBrand()
        {
            return brand;
        }
    }
}
