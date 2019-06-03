using System;
namespace POCity.Properties
{
    public class ResidentialBuilding : ZoneBuilding
    {
        bool CzyMamPark;
        bool CzyMamSzkole;
        public ResidentialBuilding(int x,
                                   int y,
                                   bool MapaMowiOWodzie,
                                   bool MapaMowiOPradzie,
                                   bool MapaMowiOPolicji,
                                   bool MapaMowiOStrazy,
                                   bool MapaMowiOSzpitalu,
                                   bool MapaMowiOParku,
                                   bool MapaMowiOSzkole)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie, MapaMowiOPolicji, MapaMowiOStrazy, MapaMowiOSzpitalu)
        {
            CzyMamPrad = MapaMowiOPradzie;
            CzyMamWode = MapaMowiOWodzie;

            CzyMamPolicje = MapaMowiOPolicji;
            CzyMamStraz = MapaMowiOStrazy;
            CzyMamSzpital = MapaMowiOSzpitalu;

            CzyMamPark = MapaMowiOParku;
            CzyMamSzkole = MapaMowiOSzkole;
            }
        public override string ToString()
        {
            return "ZR";// + x.ToString() + " " + y.ToString();
        }
    }
    public class CommercialBuilding : ZoneBuilding
    {
        bool CzyMamPark;
        public CommercialBuilding(int x,
                                  int y,
                                  bool MapaMowiOWodzie,
                                  bool MapaMowiOPradzie,
                                  bool MapaMowiOPolicji,
                                  bool MapaMowiOStrazy,
                                  bool MapaMowiOSzpitalu,
                                  bool MapaMowiOParku)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie, MapaMowiOPolicji, MapaMowiOStrazy, MapaMowiOSzpitalu)
        {

            CzyMamPrad = MapaMowiOPradzie;
            CzyMamWode = MapaMowiOWodzie;

            CzyMamPolicje = MapaMowiOPolicji;
            CzyMamStraz = MapaMowiOStrazy;
            CzyMamSzpital = MapaMowiOSzpitalu;

            CzyMamPark = MapaMowiOParku;
        }
        public override string ToString()
        {
            return "ZC";// + x.ToString() + " " + y.ToString();
        }
    }
    public class IndustrialBuilding : ZoneBuilding
    {
        public IndustrialBuilding(int x,
                                  int y,
                                  bool MapaMowiOWodzie,
                                  bool MapaMowiOPradzie,
                                  bool MapaMowiOPolicji,
                                  bool MapaMowiOStrazy,
                                  bool MapaMowiOSzpitalu)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie, MapaMowiOPolicji, MapaMowiOStrazy, MapaMowiOSzpitalu)
        {
            CzyMamPrad = MapaMowiOPradzie;
            CzyMamWode = MapaMowiOWodzie;

            CzyMamPolicje = MapaMowiOPolicji;
            CzyMamStraz = MapaMowiOStrazy;
            CzyMamSzpital = MapaMowiOSzpitalu;
        }
        public override string ToString()
        {
            return "ZI";// + x.ToString() + " " + y.ToString();
        }
    }
}
