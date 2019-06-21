using System;
namespace POCity.Properties
{
    [Serializable]
    public class WaterTower : SpecialBuilding
    {
        public WaterTower(int x, int y)
            : base(x, y)
        {
            my_name = "\u26B2 ";
        }

        public new static int GetRadius()
        {
            return 7;
        }

    }
}
