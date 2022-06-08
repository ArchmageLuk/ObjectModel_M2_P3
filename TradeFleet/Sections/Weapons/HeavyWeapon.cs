using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFleet.Sections
{
    public class HeavyWeapon : ShipParts
    {
        public HeavyWeapon()
        {
            Price = 6000;
            Cargospace = -100;
            Might = 700;
        }
    }
}
