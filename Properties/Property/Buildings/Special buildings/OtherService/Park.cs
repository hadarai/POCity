using System;
namespace POCity.Properties
{
    public class Park : SpecialBuilding
    {
        public Park(int x, int y)
            : base(x, y)
        {
            nazwa = "OP";
        }
        public s int GetRadius()
        { return 4; }
    }
}
