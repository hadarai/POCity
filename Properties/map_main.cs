using System;
using System.Collections.Generic;

namespace POCity.Properties
{
    public partial class Map
    {
        Property[,] mapa = new Property[20, 20];

        private List<PowerPlant> elektrownie = new List<PowerPlant>();
        private List<Water> wierze_cisnien = new List<Water>();

        public Map()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mapa[i, j] = null;
                }
            }
        }

        public void zawolaj_to_string(int x, int y)
        {
            if (mapa[x, y] == null)
            {
                Console.Write("BL ");
            }
            else
            {
                Console.Write(mapa[x, y].ToString());
            }
        }

        public void wypisz_mape()
        {
            for(int i=0;i<20;i++)
            {
                for(int j=0;j<20;j++)
                {
                    zawolaj_to_string(i, j);
                }
                Console.Write("\n");
            }
        }

    }
}
