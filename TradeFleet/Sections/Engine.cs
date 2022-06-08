using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFleet
{
    public class Engine : ShipParts
    {
        public Engine()
        {
            Price = 20000;
            Speed = 600;
            Cargospace = 5;
            Rooms = 2;
        }
    }
}
