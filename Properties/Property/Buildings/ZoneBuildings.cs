﻿using System;
namespace POCity.Properties
{
    public class ResidentialBuilding : ZoneBuilding
    {
        bool CzyMamPark { get; set; }
        bool CzyMamSzkole { get; set; }

        public ResidentialBuilding(int x,
                                   int y)
            : base(x, y)
        {
            nazwa = "ZR";
        }

        public void GetToKnow(Type NewNeighbour) // Mam nowego sadsiada i on mi cos daje
        {
            base.GetToKnow(NewNeighbour);

            if (NewNeighbour == typeof(Park))
            {
                CzyMamPark = true;
                //return Elektrownie;
            }
            if (NewNeighbour == typeof(School))
            {
                CzyMamSzkole = true;
                //return Elektrownie;
            }
        }

        new public bool Czy_jestem_szczesliwy()
        {
            return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital && CzyMamPark && CzyMamSzkole);
        }

        public static int GetRadius()
        {
            return 0;
        }
    }

    public class CommercialBuilding : ZoneBuilding
    {
        bool CzyMamPark { set; get; }

        public CommercialBuilding(int x, int y)
            : base(x, y)
        {
            nazwa = "ZC";
        }

        public  void GetToKnow(Type NewNeighbour) // Mam nowego sadsiada i on mi cos daje
        {
            base.GetToKnow(NewNeighbour);

            if (NewNeighbour == typeof(Park))
            {
                CzyMamPark = true;
                //return Elektrownie;
            }
        }

        public bool Czy_jestem_szczesliwy()
        {
            return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital && CzyMamPark );
        }

        public static int GetRadius()
        {
            return 0;
        }

    }

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
            return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital  );
        }

        public static int GetRadius()
        {
            return 0;
        }

    }
}
