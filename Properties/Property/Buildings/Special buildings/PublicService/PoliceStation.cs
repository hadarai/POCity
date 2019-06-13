using System;
namespace POCity.Properties
{
    public class PoliceStation : SpecialBuilding
    {
        public PoliceStation(int x, int y)
            : base(x, y)
        {
            nazwa = "PP";
        }

        public static int GetRadius()
        {
            return 10;
        }
    }
}
