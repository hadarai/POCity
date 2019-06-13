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
        public override void GetToKnow(Type NewNeighbour)
        {

        }

        public override bool AmIHappy()
        {
            return true;
        }

        public override bool AmIWater()
        {
            return true;
        }

        public override bool AmIPower()
        {
            return true;
        }
    }
}
