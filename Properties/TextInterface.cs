using System;
namespace POCity.Properties
{
    public class TextInterface
    {
        private Map plansza = new Map();

        public TextInterface()
        {
            Console.SetWindowSize(100, 100);
            Console.Clear();
            Console.WriteLine("Welcome to POCity!");

        }

        public void WypiszMape()
        {
            int index = 0;
            Console.Write("  ");
            for(int i=0;i<20;i++)
            {
                index = i + 1;
                if(index < 10)
                {
                    Console.Write(index + "  ");
                }
                else
                {
                    Console.Write(index + " ");
                }
            }

            Console.Write("\n");

            for (int i = 0; i < 20; i++)
            {
                index = i + 1;
                if (index < 10)
                {
                    Console.Write(index + " ");
                }
                else
                {
                    Console.Write(index);
                }

                for (int j = 0; j < 20; j++)
                {

                    Console.Write(plansza.ZawolajToString(i, j));
                    Console.Write(" ");
                }

                Console.Write("\n\n");
            }
            Console.Write("\n");
        }

        public void Run()
        {

            plansza.ForceRaiseHighway(1, 2);
            plansza.ForceRaiseHighway(0, 0);
            plansza.RaiseBuilding(2, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(3, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(4, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(5, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(6, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(7, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(8, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(9, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(10, 2, "POCity.Properties.Avenue");

            //plansza.WypiszMape();

            //plansza.RaiseBuilding(1, 1, "POCity.Properties.ResidentialBuilding");
            //plansza.RaiseBuilding(2, 1, "POCity.Properties.CommercialBuilding");

            plansza.RaiseBuilding(3, 1, "POCity.Properties.IndustrialBuilding");

            Console.Write("\n");
            Console.WriteLine(plansza.CzyMaszPrad(3, 1));
            Console.WriteLine(plansza.CzyMaszWode(3, 1));
            Console.WriteLine(plansza.Szczescie(3, 1));
            //Console.WriteLine(plansza.Szczescie(3, 1));

            plansza.RaiseBuilding(4, 1, "POCity.Properties.PowerPlant");
            //Console.WriteLine(plansza.CzyMaszPrad(4, 1));
            //Console.WriteLine(plansza.CzyMaszWode(4, 1));

            Console.Write("\n");
            Console.WriteLine(plansza.CzyMaszPrad(3, 1));
            Console.WriteLine(plansza.CzyMaszWode(3, 1));
            Console.WriteLine(plansza.Szczescie(3, 1));//Console.WriteLine(plansza.Szczescie(4, 1));


            //plansza.RaiseBuilding(5, 1, "POCity.Properties.WaterTower");
            //Console.WriteLine(plansza.CzyMaszPrad(5, 1));
            //Console.WriteLine(plansza.CzyMaszWode(5, 1));
            //Console.WriteLine(plansza.Szczescie(5, 1));

            Console.Write("\n");
            Console.WriteLine(plansza.CzyMaszPrad(3, 1));
            Console.WriteLine(plansza.CzyMaszWode(3, 1));
            Console.WriteLine(plansza.Szczescie(3, 1));

            plansza.RaiseBuilding(3, 3, "POCity.Properties.Healthcare");
            plansza.RaiseBuilding(4, 3, "POCity.Properties.PoliceStation");
            plansza.RaiseBuilding(2, 3, "POCity.Properties.FireDept");
            //plansza.RaiseBuilding(9, 1, "POCity.Properties.School");
            //plansza.RaiseBuilding(10, 1, "POCity.Properties.Park");

            WypiszMape();
            Console.WriteLine(plansza.Szczescie(3, 3));
            Console.WriteLine(plansza.Szczescie(4, 3));
            Console.WriteLine(plansza.Szczescie(2, 3));
            //Console.WriteLine(plansza.Szczescie(3, 1));
            //Console.WriteLine(plansza.CzyMaszPrad(3, 3));
            //Console.WriteLine(plansza.CzyMaszWode(3, 3));
            //Console.WriteLine(plansza.CzyMaszPrad(4, 3));
            //Console.WriteLine(plansza.CzyMaszWode(4, 3));
            //Console.WriteLine(plansza.CzyMaszPrad(2, 3));
            //Console.WriteLine(plansza.CzyMaszWode(2, 3));
            //Console.Write(plansza.Szczescie(5, 1));
            //Console.Clear();
            //plansza.WypiszMape();
        }
    }
}
