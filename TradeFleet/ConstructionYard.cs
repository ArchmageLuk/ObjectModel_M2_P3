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
            Console.WriteLine("Choose hull for the ship (type 'Small', 'Medium', or 'Large')");
            string? hulltype = Console.ReadLine();
            Console.WriteLine(" ");

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

            Console.WriteLine(" ");
            Console.WriteLine($"Choose what module to install in a section: cargo, weapon, rooms, or engine");
            Console.WriteLine("And what subclass of the module should it be (standard, military, or cruise)");
            Console.WriteLine("i.e. 'standard cargo' or 'cruise rooms'");
            Console.WriteLine("For weapons it's light, heavy or standard");
            Console.WriteLine(" ");

            for (int i = 0; i < emptyhull.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Choose a bridge for section {i + 1}");
                    string? parttype = Console.ReadLine();
                    ShipParts part = new Bridge();
                    new Modification().Modify(part, parttype);
                    emptyhull[i] = part;
                }

                if (i > 0 & i < emptyhull.Length - 1)
                {
                    Console.WriteLine($"Choose what module to install in the section {i + 1}: cargo, weapon, rooms, or engine");
                    Console.WriteLine("Type in the next module:");
                    string? module = Console.ReadLine();

                    string[] modulespecs = module.Split(" ");

                    ShipParts part = new ShipParts();
                    string parttype = modulespecs[0];

                    if (modulespecs[1] == "cargo")
                    {
                        part = new Cargo();
                    }
                    else if (modulespecs[1] == "engine")
                    {
                        part = new Engine();
                    }
                    else if (modulespecs[1] == "rooms")
                    {
                        part = new Rooms();
                    }
                    else if (modulespecs[1] == "weapons")
                    {
                        switch (modulespecs[0])
                        {
                            case "standard":
                                ShipParts weapon = new StandardWeapons();
                                emptyhull[i] = weapon;
                                break;
                            case "light":
                                ShipParts ltweapon = new LightWeapons();
                                emptyhull[i] = ltweapon;
                                break;
                            case "heavy":
                                ShipParts hvweapon = new HeavyWeapon();
                                emptyhull[i] = hvweapon;
                                break;
                        }
                    }

                    part = new Modification().Modify(part, parttype);
                    emptyhull[i] = part;
                }

                if (i == emptyhull.Length - 1)
                {
                    Console.WriteLine("Choose an engine for the last section");
                    string parttype = Console.ReadLine();
                    ShipParts part = new Engine();
                    part = new Modification().Modify(part, parttype);
                    emptyhull[i] = part;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please name your ship");
            string shipname = Console.ReadLine();

            double totalprice = 0;
            double totalspeed = 0;
            double totalcargospace = 0;
            double totallivingrooms = 0;
            double totalmight = 0;
            

            foreach (var part in emptyhull)
            {
                totalprice = totalprice + part.Price;
                totalspeed = totalspeed + part.Speed;
                totalcargospace = totalcargospace + part.Cargospace;
                totallivingrooms = totallivingrooms + part.Rooms;
                totalmight = totalmight + part.Might;
            }

            Console.WriteLine(" ");
            Console.WriteLine($"You ship {shipname} is ready. Here is stats of your ship:");

            Console.WriteLine($"Price = {totalprice}");
            Console.WriteLine($"Top speed = {totalspeed}");
            Console.WriteLine($"Cargo space = {totalcargospace}");
            Console.WriteLine($"Rooms for passengers and staff = {totallivingrooms}");
            Console.WriteLine($"Might of your ship = {totalmight}");
        }
    }
}
