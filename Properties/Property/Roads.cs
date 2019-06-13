using System;

namespace POCity.Properties
{
    public class PlainRoad : Road
    {
        public PlainRoad(int x, int y)
            : base(x, y)
        { 
            nazwa = "RP";
            }
        public static int GetRadius()
        {
            return 0;
        }
    }
    public class Avenue : Road
    {
        public Avenue(int x, int y)
            : base(x, y)
        {
            nazwa = "RA"; 
            }
        public static int GetRadius()
        {
            return 0;
        }
    }

    public class Highway : Road
    {
        public Highway(int x, int y)
            : base(x, y)
        {
            nazwa = "RH"; 
            }
        public static int GetRadius()
        {
            return 0;
        }
    }
}
