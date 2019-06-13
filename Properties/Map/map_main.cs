using System;
using System.Collections.Generic;

namespace POCity.Properties
{
    public partial class Map
    {
        protected int height { get; } = 20;
        protected int width { get; } = 20 ;
        Property[,] mapa;// = new Property[height, width];

        
        /*
        private int PromienPradu;
        private int PromienWody;

        private int PromienPolicji;
        private int PromienStrazy;
        private int PromienSzpitala;

        private int PromienParku;
        private int PromienSzkoly;
        */

        private List<PowerPlant> Elektrownie = new List<PowerPlant>();
        public List<Water> WiezeCisnien = new List<Water>();

        public List<Police> Policje = new List<Police>();
        public List<Fire> StrazePozarne = new List<Fire>();
        public List<Healthcare> Szpitale = new List<Healthcare>();

        public List<Park> Parki = new List<Park>();
        public List<School> Szkoly = new List<School>();


        public Map()
        {
            mapa = new Property[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    mapa[i, j] = null;
                }
            }
        }

        public string ZawolajToString(int x, int y)
        {
            if (mapa[x, y] == null)
            {
                return "  ";
            }
            else
            {
                return mapa[x, y].ToString();
            }
        }

        public void ZawolajToUpdate(int x, int y)
        {
            if (mapa[x, y] != null)
            {
                /*mapa[x, y].Odswiez(NajkrotszaOdleglosc(WiezeCisnien, x, y) < PromienWody,
                                   NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu,
                                   NajkrotszaOdleglosc(Policje, x, y) < PromienPolicji,
                                   NajkrotszaOdleglosc(StrazePozarne, x, y) < PromienStrazy,
                                   NajkrotszaOdleglosc(Szpitale, x, y) < PromienSzpitala,
                                   NajkrotszaOdleglosc(Parki, x, y) < PromienParku,
                                   NajkrotszaOdleglosc(Szkoly, x, y) < PromienSzkoly);*/
            }
        }

        public void WypiszMape()
        {
            for(int i=0;i<20;i++)
            {
                for(int j=0;j<20;j++)
                {

                    Console.Write(ZawolajToString(i, j));
                    Console.Write(" ");
                }
                
                Console.Write("\n\n");
            }
            Console.Write("\n");
        }

    }
}
