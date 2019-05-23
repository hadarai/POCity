using System;
using POCity.Properties;

namespace POCity {
    class MainClass {
        public static void Main (string[] args)
        {
            //Healthcare nowa = new Healthcare(1, 0);

            //Console.WriteLine (nowa.ToString ());


            Property[,] mapa = new Property[20, 20];

            for (int i = 0; i < 20; i++) 
            {
                for (int j = 0; j < 20; j++) 
                {
                    mapa[i, j] = null;
                }
            }

            mapa[10, 7] = new PlainRoad(10, 7);
            Console.WriteLine (mapa[10, 7].ToString());
        }
    }
}