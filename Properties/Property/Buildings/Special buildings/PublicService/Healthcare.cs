using System;
namespace POCity.Properties
{
    public class Healthcare : SpecialBuilding
    {
        public Healthcare(int x, int y)
            : base(x, y)
        {
            nazwa = "PH";
        }
        public static int GetRadius()
        {
            return 10;
        }
    }
}
