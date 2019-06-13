using System;
namespace POCity.Properties
{


    public class SpecialBuilding : Building
    {
        public SpecialBuilding(int x, int y)
            : base(x, y)
        { }

        public new static int GetRadius()
        {
            return 0;
        }

    }
}
