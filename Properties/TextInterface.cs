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

        public void Run()
        {
            //Setup();
            plansza.ForceRaiseHighway(1, 2); //0-plain, 1-alley, 2-highway
            plansza.RaiseBuilding(2, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(3, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(4, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(5, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(6, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(7, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(8, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(9, 2, "POCity.Properties.Avenue");
            plansza.RaiseBuilding(10, 2, "POCity.Properties.Avenue");
            //plansza.ForceRaiseHighway(2, 2, 1); 
            //plansza.ForceRaiseHighway(3, 2, 1); 
            //plansza.ForceRaiseHighway(4, 2, 1); 
            //plansza.ForceRaiseHighway(5, 2, 1); 
            //plansza.ForceRaiseHighway(6, 2, 1);
            //plansza.ForceRaiseHighway(7, 2,);
            //plansza.ForceRaiseHighway(8, 2);
            //plansza.ForceRaiseHighway(9, 2);
            //plansza.ForceRaiseHighway(10, 2);
            //plansza.WypiszMape();

            //plansza.PostawDom(1, 1);
            plansza.RaiseBuilding(1, 1, "POCity.Properties.ResidentialBuilding");
            plansza.RaiseBuilding(2, 1, "POCity.Properties.CommercialBuilding");
            plansza.RaiseBuilding(3, 1, "POCity.Properties.IndustrialBuilding");
            plansza.RaiseBuilding(4, 1, "POCity.Properties.PowerPlant");
            plansza.RaiseBuilding(5, 1, "POCity.Properties.WaterTower");
            plansza.RaiseBuilding(6, 1, "POCity.Properties.Healthcare");
            plansza.RaiseBuilding(7, 1, "POCity.Properties.PoliceStation");
            plansza.RaiseBuilding(8, 1, "POCity.Properties.FireDept");
            plansza.RaiseBuilding(9, 1, "POCity.Properties.School");
            plansza.RaiseBuilding(10, 1, "POCity.Properties.Park");


            plansza.WypiszMape();

            //Console.Clear();
            //plansza.WypiszMape();
        }
    }
}
