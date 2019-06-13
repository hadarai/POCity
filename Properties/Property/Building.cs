using System;
using System.Collections.Generic;

namespace POCity.Properties
{
    public class Building : Property
    {
        public bool CzyMamWode { get; set; }
        public bool CzyMamPrad { get; set; }

        public List<Type> wymagane_budynki = new List<Type>();

        protected Building(int x, int y)
            : base(x, y)
        {

            wymagane_budynki.Add(typeof(PowerPlant));
            wymagane_budynki.Add(typeof(WaterTower));
        }

        public override void GetToKnow(Type NewNeighbour) //= Update
        {
            //Console.WriteLine("siema");
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

        public override bool AmIHappy()
        {
            return CzyMamPrad && CzyMamWode;
        }

        public override bool AmIWater()
        {
            return CzyMamWode;
        }

        public override bool AmIPower()
        {
            return CzyMamPrad;
        }
    }
}
