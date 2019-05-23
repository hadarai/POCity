using System;

namespace POCity.Properties
{
    public class PlainRoad : Road
    {
        public PlainRoad(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "RP " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class Alley : Road
    {
        public Alley(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "RA " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class Highway : Road
    {
        public Highway(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "RH " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
