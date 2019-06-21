using System;
namespace POCity.Properties
{
    [Serializable]
    public class Park : SpecialBuilding
    {
        public Park(int x, int y)
            : base(x, y)
        {
            my_name = "\u26F9";
        }
        public new static int GetRadius()
        {
            return 4;
        }
    }
}
