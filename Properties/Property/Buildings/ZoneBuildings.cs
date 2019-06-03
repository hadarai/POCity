using System;
namespace POCity.Properties
{
    public class ResidentialBuilding : ZoneBuilding
    {
        public ResidentialBuilding(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie, bool MapaMowiOPolicji, bool MapaMowiOStrazy, bool MapaMowiOSzpitalu)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie, MapaMowiOPolicji, MapaMowiOStrazy, MapaMowiOSzpitalu)
        { }
        public override string ToString()
        {
            return "ZR";// + x.ToString() + " " + y.ToString();
        }
    }
    public class CommercialBuilding : ZoneBuilding
    {
        public CommercialBuilding(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie, bool MapaMowiOPolicji, bool MapaMowiOStrazy, bool MapaMowiOSzpitalu)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie, MapaMowiOPolicji, MapaMowiOStrazy, MapaMowiOSzpitalu)
        { }
        public override string ToString()
        {
            return "ZC";// + x.ToString() + " " + y.ToString();
        }
    }
    public class IndustrialBuilding : ZoneBuilding
    {
        public IndustrialBuilding(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie, bool MapaMowiOPolicji, bool MapaMowiOStrazy, bool MapaMowiOSzpitalu)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie, MapaMowiOPolicji, MapaMowiOStrazy, MapaMowiOSzpitalu)
        { }
        public override string ToString()
        {
            return "ZI";// + x.ToString() + " " + y.ToString();
        }
    }
}
