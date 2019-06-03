using System;
namespace POCity.Properties
{
    public class ZoneBuilding : Building
    {
        protected bool CzyMamPolicje { get; set; }
        protected bool CzyMamStraz { get; set; }
        protected bool CzyMamSzpital { get; set; }

        public ZoneBuilding(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie, bool MapaMowiOPolicji, bool MapaMowiOStrazy, bool MapaMowiOSzpitalu)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        {
            CzyMamPolicje = MapaMowiOPolicji;
            CzyMamStraz = MapaMowiOStrazy;
            CzyMamSzpital = MapaMowiOSzpitalu;
            }

        public override string ToString()
        {
            return "Jestem ZoneBuilding " + x.ToString() + " " + y.ToString();
        }
    }
    public class SpecialBuilding : Building
    {
        public SpecialBuilding(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        { }
        public override string ToString()
        {
            return "Jestem SpecjalnymBudynkiem " + x.ToString() + " " + y.ToString();
        }
    }
}
