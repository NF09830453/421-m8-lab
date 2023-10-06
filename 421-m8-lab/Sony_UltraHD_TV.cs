using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Sony_UltraHD_TV: Sony_TV, UltraHD_TVIF
    {
        public Sony_UltraHD_TV() : base()
        {
            this.SetPrice(480);
            this.SetType("UltraHD");
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " Brand: " + GetBrand();
        }
    }
}
