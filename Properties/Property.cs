using System;
using System.Collections.Generic;

namespace POCity.Properties
{

    public abstract class Property
    {
        public int x;
        public int y;

        public Property(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public override string ToString()
        {
            return "Jestem dzialka " + x.ToString() + " " + y.ToString();
        }
    }
    /*
    public class Blank_Space : Property
    {

        public override string ToString()
        {
            return "BL " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    */
    public class Building : Property
    {
        protected bool czy_ma_wode { get; set; }
        protected bool czy_ma_prad { get; set; }

        virtual public bool CzyWystarczajacoBlisko(double distance)
        { 
            return true; 
            }

        //public Building(int x, int y)
        public Building (int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y)
        {
            czy_ma_wode = false;  //= policz_czy_ma_wode(X, Y);
            czy_ma_prad = false; //= policz_czy_ma_prad(X, Y);
        }
        public override string ToString()
        {
            return "Jestem budynkiem " + x.ToString() + " " + y.ToString();
        }
    }

    public class Road : Property
    {
        //bycie droga
        public Road(int x, int y)
            : base(x,y)
        { }

        public override string ToString()
        {
            return "Jestem droga " + x.ToString() + " " + y.ToString();
        }
    }
}

