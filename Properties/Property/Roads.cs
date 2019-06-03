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
            return "RP"; // + x.ToString() + " " + y.ToString();
        }
    }
    public class Alley : Road
    {
        public Alley(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "RA"; // + x.ToString() + " " + y.ToString();
        }
    }
    public class Highway : Road
    {
        public Highway(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "RH"; // + x.ToString() + " " + y.ToString();
        }
    }
}
