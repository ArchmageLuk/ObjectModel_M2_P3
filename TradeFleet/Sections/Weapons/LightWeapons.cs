using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFleet.Sections
{
    public class LightWeapons : ShipParts 
    {
        public LightWeapons()
        {
            Price = 2000;
            Cargospace = -10;
            Might = 150;
        }
    }
}
