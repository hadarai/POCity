using System;
using POCity.Properties;

namespace POCity {
    class MainClass {
        public static void Main (string[] args)
        {
            Map plansza = new Map();
            plansza.WypiszMape();

            plansza.PostawDroge (1, 2, 2); //0-plain, 1-alley, 2-highway
            plansza.WypiszMape();

            //plansza.zawolaj_to_string(1, 2);
            //Water wierza1 = new Water(7, 11);
            //Water wierza2 = new Water(9, 2);

            //plansza.wierze_cisnien.Add(wierza1);
            //plansza.wierze_cisnien.Add(wierza2);
            plansza.PostawElektrownie(1, 1);
            plansza.WypiszMape();
            //plansza.wypisz_mape();
        }
    }
}