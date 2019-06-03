using System;
using System.Collections.Generic;

namespace POCity.Properties
{
    public partial class Map
    {
        Property[,] mapa = new Property[20, 20];

        private int PromienPradu;
        private int PromienWody;

        private int PromienPolicji;
        private int PromienStrazy;
        private int PromienSzpitala;

        private int PromienParku;
        private int PromienSzkoly;

        private List<PowerPlant> Elektrownie = new List<PowerPlant>();
        public List<Water> WierzeCisnien = new List<Water>();

        public List<Police> Policje = new List<Police>();
        public List<Fire> StrazePozarne = new List<Fire>();
        public List<Healthcare> Szpitale = new List<Healthcare>();

        public List<Park> Parki = new List<Park>();
        public List<School> Szkoly = new List<School>();


        public Map()
        {
            PromienPradu = 7;
            PromienWody = 5;

            PromienPolicji = 10;
            PromienStrazy = 10;
            PromienSzpitala = 10;

            PromienParku = 4;
            PromienSzkoly = 6;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mapa[i, j] = null;
                }
            }
        }

        public void ZawolajToString(int x, int y)
        {
            if (mapa[x, y] == null)
            {
                //Console.Write("BL");
                Console.Write("  ");
            }
            else
            {
                Console.Write(mapa[x, y].ToString());
            }
        }

        public void WypiszMape()
        {
            for(int i=0;i<20;i++)
            {
                for(int j=0;j<20;j++)
                {
                    ZawolajToString(i, j);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

    }
}
