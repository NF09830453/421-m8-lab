using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSystem
{
    public class Sony_TV: TV
    {
        public Sony_TV() : base()
        {
            this.SetPrice(280);
            this.SetBrand("Sony");

        }
    }
}
