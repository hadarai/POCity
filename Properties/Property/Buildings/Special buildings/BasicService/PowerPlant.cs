using System;
namespace POCity.Properties
{
    [Serializable]
    public class PowerPlant : SpecialBuilding
    {
        public PowerPlant(int x, int y)
            : base(x, y)
        {
            my_name = "\u26A1";
        }

        public new static int GetRadius()
        {
            return 8;
        }

    }
}
