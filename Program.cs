using System;
using POCity.Properties;

namespace POCity {
    class MainClass {
        public static void Main (string[] args)
        {
            //Healthcare nowa = new Healthcare(1, 0);

            //Console.WriteLine (nowa.ToString ());

            Map plansza = new Map();

            plansza.postaw_droge (1, 2, 0); //0-plain, 1-alley, 2-highway
            //plansza.zawolaj_to_string(1, 2);

            plansza.wypisz_mape();
        }
    }
}