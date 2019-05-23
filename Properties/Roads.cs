using System;

namespace POCity.Properties
{
    public class PlainRoad : Road
    {
        public override string ToString()
        {
            return "RP " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class Alley : Road
    {
        public override string ToString()
        {
            return "RA " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class Highway : Road
    {
        public override string ToString()
        {
            return "RH " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
