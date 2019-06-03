using System;
namespace POCity.Properties
{
    public class PowerPlant : BasicService
    {
        public PowerPlant(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        {
            CzyMamPrad = true;
            CzyMamWode = MapaMowiOWodzie;
        }
        
        public override string ToString()
        {
            return "BP";// + x.ToString() + " " + y.ToString();
        }
    }
    public class Water : BasicService
    {
        public Water(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        {
            CzyMamPrad = MapaMowiOPradzie;
            CzyMamWode = true;
        }

        public override string ToString()
        {
            return "BW";// + x.ToString() + " " + y.ToString();
        }
    }
}
