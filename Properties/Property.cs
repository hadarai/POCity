using System;
using System.Collections.Generic;

namespace POCity.Properties
{

    public abstract class Property
    {
        public int x;
        public int y;
        protected string nazwa;
        protected int PromienPradu = 7;

        protected Property(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public override string ToString()
        {
            return this.nazwa; //+ " " + x.ToString() + " " + y.ToString();
        }

        public static int GetRadius()
        {
            return 0;
        }
    }

    public class Building : Property
    {
        protected bool CzyMamWode { get; set; }
        protected bool CzyMamPrad { get; set; }

        public List<Type> wymagane_budynki = new List<Type>();

        protected Building(int x, int y)
            : base(x, y)
        {
           
            wymagane_budynki.Add(typeof(PowerPlant));
            wymagane_budynki.Add(typeof(Water));
        }

        public void GetToKnow(Type NewNeighbour) //= Update
        {
            if (NewNeighbour == typeof(PowerPlant))
            {
                CzyMamPrad = true;
                //return Elektrownie;
            }
            else if (NewNeighbour == typeof(Water))
            {
                CzyMamWode = true;
                //return WiezeCisnien;
            }

        }


    }

    public class Road : Property
    {
        //bycie droga
        public Road(int x, int y)
            : base(x,y)
        { }

        new public static int GetRadius()
        {
            return 0;
        }
    }
}

