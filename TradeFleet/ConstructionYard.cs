using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeFleet.Sections;

namespace TradeFleet
{
    public class ConstructionYard
    {
        public void ShipConstruction()
        {
            Console.WriteLine("Welcome, Head Engineer.");
            Console.WriteLine("Construction Yard is operational and ready");
            Console.WriteLine("Choose hull for the ship (type 'Small', 'Medium', or 'Large'");
            string? hulltype = Console.ReadLine();

            int shipsize = 1;

            if (hulltype == "Small" ^ hulltype == "small")
            {
                shipsize = 3;
            }

            if (hulltype == "Medium" ^ hulltype == "medium")
            {
                shipsize = 5;
            }

            if (hulltype == "Large" ^ hulltype == "large")
            {
                shipsize = 7;
            }

            ShipParts[] emptyhull = new ShipParts[shipsize];
            Console.WriteLine(shipsize);

            for (int i = 0; i < emptyhull.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Choose a bridge for section {i + 1}");
                    ShipParts bridge = new Bridge();
                    emptyhull[i] = bridge;
                }

                if (i > 0 & i < emptyhull.Length - 1)
                {
                    Console.WriteLine($"Choose what to install in the section {i + 1}: cargo, weapon, rooms, or engine");
                    string? module = Console.ReadLine();
                    
                    if (module == "cargo")
                    {
                        ShipParts cargo = new Cargo();
                        emptyhull[i] = cargo;
                    }

                    if (module == "weapon")
                    {
                        ShipParts weapon = new Weapons();
                        emptyhull[i] = weapon;
                    }

                    if (module == "rooms")
                    {
                        ShipParts rooms = new Rooms();
                        emptyhull[i] = rooms;
                    }

                    if (module == "engine")
                    {
                        ShipParts engine = new Engine();
                        emptyhull[i] = engine;
                    }
                }

                if (i == emptyhull.Length - 1)
                {
                    Console.WriteLine("Choose an engine for the last section");
                    ShipParts engine = new Engine();
                    emptyhull[i] = engine;
                }
            }

            int totalprice = 0;
            int totalspeed = 0;
            int totalcargospace = 0;
            int totallivingrooms = 0;

            foreach (var part in emptyhull)
            {
                totalprice = totalprice + part.Price;
                totalspeed = totalspeed + part.Speed;
                totalcargospace = totalcargospace + part.Cargospace;
                totallivingrooms = totallivingrooms + part.Rooms;
            }

            Console.WriteLine($"You ship is ready. Here is stats of your ship:");
            Console.WriteLine($"Price = {totalprice}");
            Console.WriteLine($"Top speed = {totalspeed}");
            Console.WriteLine($"Cargo space = {totalcargospace}");
            Console.WriteLine($"Rooms for passengers and staff = {totallivingrooms}");
        }
    }
}
