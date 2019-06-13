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
            Console.WriteLine("Hello in POCity!");

        }

        public void Run()
        {
            //Setup();
            plansza.PostawDroge(1, 2, 1); //0-plain, 1-alley, 2-highway
            plansza.PostawDroge(2, 2, 1); 
            plansza.PostawDroge(3, 2, 1); 
            plansza.PostawDroge(4, 2, 1); 
            plansza.PostawDroge(5, 2, 1); 
            plansza.PostawDroge(6, 2, 1);
            plansza.PostawDroge(7, 2, 1);
            plansza.PostawDroge(8, 2, 1);
            plansza.PostawDroge(9, 2, 1);
            plansza.PostawDroge(10, 2, 1);
            //plansza.WypiszMape();

            //plansza.PostawDom(1, 1);
            plansza.RaiseBuilding(1, 1, "POCity.Properties.ResidentialBuilding");
            plansza.RaiseBuilding(2, 1, "POCity.Properties.CommercialBuilding");
            plansza.RaiseBuilding(3, 1, "POCity.Properties.IndustrialBuilding");
            plansza.RaiseBuilding(4, 1, "POCity.Properties.Healthcare");
            plansza.RaiseBuilding(5, 1, "POCity.Properties.Police");
            plansza.RaiseBuilding(6, 1, "POCity.Properties.Fire");
            plansza.RaiseBuilding(7, 1, "POCity.Properties.PowerPlant");
            plansza.RaiseBuilding(8, 1, "POCity.Properties.Water");
            plansza.RaiseBuilding(9, 1, "POCity.Properties.School");
            plansza.RaiseBuilding(10, 1, "POCity.Properties.Park");
            plansza.WypiszMape();

            //Console.Clear();
            //plansza.WypiszMape();
        }
    }
}
