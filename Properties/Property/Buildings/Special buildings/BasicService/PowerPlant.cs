using System;
namespace POCity.Properties
{
    public class PowerPlant : SpecialBuilding
    {
        public PowerPlant(int x, int y)
            : base(x, y)
        {
            nazwa = "BP";
        }


        public static int GetRadius()
        { return 8; }

    }
}
