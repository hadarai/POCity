using System;
namespace POCity.Properties
{
    public class FireDept : SpecialBuilding
    {
        public FireDept(int x, int y)
            : base(x, y)
        {
            nazwa = "PF";
        }

        public static int GetRadius()
        {
            return 10;
        }
    }
}
