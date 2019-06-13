using System;
namespace POCity.Properties
{
    public class IndustrialBuilding : ZoneBuilding
    {
        public IndustrialBuilding(int x,
                                  int y)
            : base(x, y)
        {
            nazwa = "ZI";
        }

        public bool Czy_jestem_szczesliwy()
        {
            return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital);
        }

        public static int GetRadius()
        {
            return 0;
        }

    }
}
