using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFleet.Sections
{
    public class Rooms : ShipParts
    {
        public Rooms()
        {
            Price = 10000;
            Speed = 0;
            Cargospace = 20;
            Rooms = 20;
        }
    }
}
