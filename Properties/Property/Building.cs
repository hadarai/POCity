using System;
using System.Collections.Generic;

namespace POCity.Properties
{
    public class Building : Property
    {
        protected bool CzyMamWode { get; set; }
        protected bool CzyMamPrad { get; set; }

        public List<Type> wymagane_budynki = new List<Type>();

        protected Building(int x, int y)
            : base(x, y)
        {

            wymagane_budynki.Add(typeof(PowerPlant));
            wymagane_budynki.Add(typeof(WaterTower));
        }

        public void GetToKnow(Type NewNeighbour) //= Update
        {
            if (NewNeighbour == typeof(PowerPlant))
            {
                CzyMamPrad = true;
                //return Elektrownie;
            }
            else if (NewNeighbour == typeof(WaterTower))
            {
                CzyMamWode = true;
                //return WiezeCisnien;
            }

        }


    }
}
