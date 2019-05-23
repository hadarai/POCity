using System;
using POCity.Properties;

namespace POCity {
    class MainClass {
        public static void Main (string[] args)
        {
            Property wlasnosc = new Property ();
            wlasnosc.X = 7;
            wlasnosc.Y = 8;
            //Wlasnosc.ToString();
            Console.WriteLine (wlasnosc.ToString());

            Healthcare nowa = new Healthcare ();
            nowa.X = 1;
            nowa.Y = 0;
            Console.WriteLine (nowa.ToString ());


            Property[,] mapa = new Property[20, 20];

            for (int i = 0; i < 20; i++) 
            {
                for (int j = 0; j < 20; j++) 
                {
                    mapa[i,j] = new Property();
                }
            }

        }
    }
}