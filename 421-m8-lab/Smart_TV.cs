using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public sealed class Smart_TV : TV
    {
        private double power;
        internal double getPowerUsage()
        {
            return power;
        }
    }
}
