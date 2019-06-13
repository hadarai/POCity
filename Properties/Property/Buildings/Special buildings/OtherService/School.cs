using System;
namespace POCity.Properties
{
    public class School : SpecialBuilding
    {
        public School(int x, int y)
            : base(x, y)
        {
            nazwa = "OS";
        }
        public static int GetRadius()
        {
            return 6;
        }

    }
}
