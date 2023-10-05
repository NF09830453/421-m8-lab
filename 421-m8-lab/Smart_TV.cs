using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public sealed class Smart_TV : TV, Smart_TVIF
    {
        // A Smart_TV object further has a “~getPowerUsage(): double” method
        // to display 5.5 watts power usage per hour.
        private double power=5.5;
        public Smart_TV() : base()
        {
            this.SetPrice(300);
            this.SetType("Smart");
        }
        public double GetPowerUsage()
        {
            return power;
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Power Usage: " + this.GetPowerUsage() + "watts per hour");
        }
    }
}
