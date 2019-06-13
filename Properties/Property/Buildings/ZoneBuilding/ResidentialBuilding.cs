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

        public new void GetToKnow(Type NewNeighbour) // Mam nowego sadsiada i on mi cos daje
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

        new public bool AmIHappy()
        {
            return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital && CzyMamPark && CzyMamSzkole);
        }

        public new static int GetRadius()
        {
            return 0;
        }
    }
}