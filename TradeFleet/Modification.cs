using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFleet.Sections
{
    public class Modification : ShipParts
    {
        public ShipParts Modify(ShipParts part, string modification)
        {
            switch (modification)
            {
                case "standard":
                    part.Partname = "Standard " + part.Partname;
                    break;

                case "cruise":
                    part.Partname = "Cruise " + part.Partname;
                    part.Price = part.Price * 1.5;
                    part.Speed = part.Speed * 0.8;
                    part.Cargospace = part.Cargospace * 1.2;
                    part.Rooms = part.Rooms * 2;
                    part.Might = part.Might * 0.5;
                    break;

                case "military":
                    part.Partname = "Military " + part.Partname;
                    part.Price = part.Price * 1.6;
                    part.Speed = part.Speed * 1.2;
                    part.Cargospace = part.Cargospace * 0.8;
                    part.Rooms = part.Rooms * 0.8;
                    break;
            }

            return part;
        }

    }
}
