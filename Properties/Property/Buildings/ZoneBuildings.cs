using System;
namespace POCity.Properties
{
    public class ResidentialBuilding : ZoneBuilding
    {
        public ResidentialBuilding(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "ZR " + X.ToString() + " " + Y.ToString();
        }
    }
    public class Commercial : ZoneBuilding
    {
        public Commercial(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "ZC " + X.ToString() + " " + Y.ToString();
        }
    }
    public class IndustrialBuilding : ZoneBuilding
    {
        public IndustrialBuilding(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "ZI " + X.ToString() + " " + Y.ToString();
        }
    }
}
