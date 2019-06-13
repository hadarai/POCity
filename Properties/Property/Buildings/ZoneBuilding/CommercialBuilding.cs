using System;
namespace POCity.Properties
{
    public class CommercialBuilding : ZoneBuilding
    {
        bool CzyMamPark { set; get; }

        public CommercialBuilding(int x, int y)
            : base(x, y)
        {
            nazwa = "ZC";
        }

        public void GetToKnow(Type NewNeighbour) // Mam nowego sadsiada i on mi cos daje
        {
            base.GetToKnow(NewNeighbour);

            if (NewNeighbour == typeof(Park))
            {
                CzyMamPark = true;
            }
        }

        public bool Czy_jestem_szczesliwy()
        {
            return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital && CzyMamPark);
        }

        public static int GetRadius()
        {
            return 0;
        }

    }
}
