using System;
namespace POCity.Properties
{
    [Serializable]
    public class Hospital : SpecialBuilding
    {
        public Hospital(int x, int y)
            : base(x, y)
        {
            my_name = "\u2624 ";
        }
        public new static int GetRadius()
        {
            return 10;
        }
    }
}
