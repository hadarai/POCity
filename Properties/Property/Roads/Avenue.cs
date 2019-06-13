using System;
namespace POCity.Properties
{
    public class Avenue : Road
    {
        public Avenue(int x, int y)
            : base(x, y)
        {
            nazwa = "RA";
        }
        public static int GetRadius()
        {
            return 0;
        }
        public void GetToKnow(Type NewNeighbour)
        {

        }
    }
}
