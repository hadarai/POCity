using System;
namespace POCity.Properties
{
    public class Road : Property
    {
        public Road(int x, int y)
            : base(x, y)
        { }

        new public static int GetRadius()
        {
            return 0;
        }
        public void GetToKnow(Type NewNeighbour)
        {

        }
    }
}
