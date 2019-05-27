using System;
namespace POCity.Properties
{
    public class Power : BasicService
    {
        public Power(int x, int y)
            : base(x, y)
        {
            radius = 7;
        }

        public override string ToString()
        {
            return "BP " + X.ToString() + " " + Y.ToString();
        }
    }
    public class Water : BasicService
    {
        public Water(int x, int y)
            : base(x, y)
        {
            radius = 5;
        }

        public override string ToString()
        {
            return "BW " + X.ToString() + " " + Y.ToString();
        }
    }
}
