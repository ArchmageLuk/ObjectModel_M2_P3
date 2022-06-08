using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFleet.Sections
{
    public class StandardWeapons : ShipParts 
    {
        public StandardWeapons()
        {
            Price = 3500;
            Cargospace = -25;
            Might = 300;
        }
    }
}
