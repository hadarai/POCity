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
}
