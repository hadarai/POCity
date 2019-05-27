using System;
namespace POCity.Properties
{
    public class ZoneBuilding : Building
    {
        public ZoneBuilding(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "Jestem zone building " + X.ToString() + " " + Y.ToString();
        }
    }
    public class SpecialBuilding : Building
    {
        public int radius;

        public SpecialBuilding(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "Jestem specjalnym budynkiem " + X.ToString() + " " + Y.ToString();
        }
    }
}
