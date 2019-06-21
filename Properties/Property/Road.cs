using System;
namespace POCity.Properties
{
    [Serializable]
    public class Road : Property
    {
        public Road(int x, int y)
            : base(x, y)
        { }

        new public static int GetRadius()
        {
            return 0;
        }
        public override void GetToKnow(Type new_neighbour)
        { }

        public override string IsWorking()
        {
            return "\u2714";
        }

        public override string GotWater()
        {
            return "\u2714";
        }

        public override string GotPower()
        {
            return "\u2714";
        }

        public override int WorthPoints()
        {
            return 0;
        }
    }
}
