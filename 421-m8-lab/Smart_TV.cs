using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public sealed class Smart_TV : TV
    {
        private double power = 5.5;
        public Smart_TV()
        {
            SetPrice(300);
            SetType("Smart");
        }
        internal double GetPowerUsage()
        {
            return power;
        }

        internal void SetPowerUsage(double power)
        {
            this.power = power;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Power: " + GetPowerUsage() + " W";
        }
    }
}
