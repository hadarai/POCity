using System;
namespace POCity.Properties
{
    public class ZoneBuilding : Building
    {
        public override string ToString()
        {
            return "Jestem zone building " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class SpecialBuilding : Building
    {
        public int radius;

        public override string ToString()
        {
            return "Jestem specjalnym budynkiem " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
