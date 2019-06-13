using System;
namespace POCity.Properties
{
    public class Highway : Road
    {
        public Highway(int x, int y)
            : base(x, y)
        {
            nazwa = "RH";
        }
        public static int GetRadius()
        {
            return 0;
        }
    }
}
