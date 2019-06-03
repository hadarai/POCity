using System;
namespace POCity.Properties
{
    public partial class Map
    {
        public void PostawDom(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                mapa[x, y] = new ResidentialBuilding(x, y,
                    NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody, 
                    NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu, 
                    NajkrotszaOdleglosc(Policje, x, y) < PromienPolicji,
                    NajkrotszaOdleglosc(StrazePozarne, x, y) < PromienStrazy,
                    NajkrotszaOdleglosc(Szpitale, x, y) < PromienSzpitala,
                    NajkrotszaOdleglosc(Parki, x, y) < PromienParku,
                    NajkrotszaOdleglosc(Szkoly, x, y) < PromienSzkoly);

            }
        }
        public void PostawSklep(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                mapa[x, y] = new CommercialBuilding(x, y,
                    NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody,
                    NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu,
                    NajkrotszaOdleglosc(Policje, x, y) < PromienPolicji,
                    NajkrotszaOdleglosc(StrazePozarne, x, y) < PromienStrazy,
                    NajkrotszaOdleglosc(Szpitale, x, y) < PromienSzpitala,
                    NajkrotszaOdleglosc(Parki, x, y) <PromienParku);

            }
        }
        public void PostawFabryke(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                mapa[x, y] = new IndustrialBuilding(x, y,
                    NajkrotszaOdleglosc(WierzeCisnien, x, y) < PromienWody,
                    NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu,
                    NajkrotszaOdleglosc(Policje, x, y) < PromienPolicji,
                    NajkrotszaOdleglosc(StrazePozarne, x, y) < PromienStrazy,
                    NajkrotszaOdleglosc(Szpitale, x, y) < PromienSzpitala);

            }
        }
    }
}
