using System;
namespace POCity.Properties
{
    public class WaterTower : SpecialBuilding
    {
        public WaterTower(int x, int y)
            : base(x, y)
        {
            nazwa = "BW";
        }

        public new static int GetRadius()
        { return 7; }

    }
}
