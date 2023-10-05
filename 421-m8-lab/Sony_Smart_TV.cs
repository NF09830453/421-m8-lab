using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Sony_Smart_TV: Sony_TV, Smart_TVIF
    {
        public Sony_Smart_TV() : base()
        {
            this.SetPrice(380);
            this.SetBrand("Sony");
            this.SetType("Smart TV");
        }

        public double GetPowerUsage()
        {
            return 5.15;
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Power Usage: " + this.GetPowerUsage() + " watts per hour");
        }
    }
}
