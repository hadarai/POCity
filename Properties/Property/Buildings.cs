using System;
namespace POCity.Properties
{
    public class ZoneBuilding : Building
    {
        protected bool CzyMamPolicje { get; set; }
        protected bool CzyMamStraz { get; set; }
        protected bool CzyMamSzpital { get; set; }

        public ZoneBuilding(int x, int y)
            : base(x, y) 
            { }


        new public void GetToKnow(Type NewNeighbour) // Mam nowego sadsiada i on mi cos daje
        {
            base.GetToKnow(NewNeighbour);

            if (NewNeighbour == typeof(Healthcare))
            {
                CzyMamSzpital = true;
                //return Szpitale;
            }
            if (NewNeighbour == typeof(PoliceStation))
            {
                CzyMamPolicje = true;
                //return Policje;
            }
            if (NewNeighbour == typeof(FireDept))
            {
                CzyMamStraz = true;
                //return StrazePozarn1e;
            }
        }

        public virtual bool Czy_jestem_szczesliwy()
        { 
            return false; 
            }
        public static int GetRadius()
        {
            return 0;
        }
    }

    public class SpecialBuilding : Building
    {
        public SpecialBuilding(int x, int y)
            : base(x, y)
            { }

        public static int GetRadius()
        {
            return 0;
        }

    }
}
