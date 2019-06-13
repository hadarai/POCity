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

        public override bool AmIHappy()
        {
            //Console.WriteLine("elooo");
            return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital);
        }

        //public override bool Czy_jestem_szczesliwy()
        //{
        //    Console.WriteLine("elooo");
        //    return (CzyMamPrad && CzyMamWode && CzyMamPolicje && CzyMamStraz && CzyMamSzpital);
        //}

        public new static int GetRadius()
        {
            return 0;
        }

    }
}
