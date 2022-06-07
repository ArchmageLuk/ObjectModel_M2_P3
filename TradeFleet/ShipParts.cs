using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFleet
{
    public class ShipParts
    {
        public int Price = 10;
        public int Speed = 10;
        public int Cargospace = 1;
        public int Rooms = 1;


        public ShipParts INeedSection(string section)
        {
            ShipParts thepart = new ShipParts();
            if (section == "bridge")
            {
                thepart = new Bridge();
            }

            if (section == "cargo")
            {
                thepart = new Cargo();
            }

            return thepart;
        }
    }
}

