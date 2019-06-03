using System;
namespace POCity.Properties
{
    public partial class Map
    {

        public void PostawElektrownie(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                PowerPlant temp = new PowerPlant(x, y, NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody, true);

                mapa[x, y] = temp;
                Elektrownie.Add(temp);
            }
        }

        public void PostawWierzeCisnien(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                Water temp = new Water(x, y, true, NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu);

                mapa[x, y] = temp;
                WierzeCisnien.Add(temp);
            }
        }

        public void PostawPolicje(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                Police temp = new Police(x, y, NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody, NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu);

                mapa[x, y] = temp;
                Policje.Add(temp);
            }
        }

        public void PostawStraz(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                Fire temp = new Fire(x, y, NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody, NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu);

                mapa[x, y] = temp;
                StrazePozarne.Add(temp);
            }
        }

        public void PostawSzpital(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                Healthcare temp = new Healthcare(x, y, NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody, NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu);

                mapa[x, y] = temp;
                Szpitale.Add(temp);
            }
        }

        public void PostawPark(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                Park temp = new Park(x, y, NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody, NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu);

                mapa[x, y] = temp;
                Parki.Add(temp);
            }
        }

        public void PostawSzkole(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                School temp = new School(x, y, NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody, NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu);

                mapa[x, y] = temp;
                Szkoly.Add(temp);
            }
        }
    }
}
