﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Vizio_Smart_TV: Vizio_TV, Smart_TVIF
    {
        private Smart_TV st = new Smart_TV();
        public Vizio_Smart_TV()
        {
            SetBrand("Vizio");
            st.SetPrice(350);
            st.SetPowerUsage(6.35);
        }

        public override string GetInfo()
        {
            return st.GetInfo() + " Brand: "+ GetBrand();
        }
    }
}
