using System;
namespace POCity.Properties
{
    [Serializable]
    public class PoliceStation : SpecialBuilding
    {
        public PoliceStation(int x, int y)
            : base(x, y)
        {
            my_name = "\u2696 ";
        }

        public new static int GetRadius()
        {
            return 10;
        }

    }
}
