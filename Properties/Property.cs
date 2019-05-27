using System;
using System.Collections.Generic;

namespace POCity.Properties
{

    public abstract class Property
    {
        public int X;
        public int Y;

        public Property(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "Jestem dzialka " + X.ToString() + " " + Y.ToString();
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
        public bool czy_ma_wode;
        public bool czy_ma_prad;

        public Building(int x, int y)
            : base(x, y)
        {

            //base(x, y);
            czy_ma_wode = false; //= policz_czy_ma_wode(X, Y);
            czy_ma_prad = false; //= policz_czy_ma_prad(X, Y);
        }
        public override string ToString()
        {
            return "Jestem budynkiem " + X.ToString() + " " + Y.ToString() + "\n";
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
            return "Jestem droga " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}

