using System;
namespace POCity.Properties
{
    public partial class Map
    {
        public void postaw_droge(int x, int y, int typ)
        {
            if (czy_moge_tu_cokolwiek(x, y) && czy_obok_jest_droga(x, y))
            {
                if (typ == 0)
                {
                    mapa[x, y] = new PlainRoad(x, y);
                }
                else if (typ == 1)
                {
                    mapa[x, y] = new Alley(x, y);
                }
                else
                {
                    mapa[x, y] = new Highway(x, y);
                }
            }
        }

        public void postaw_elektrownie(int x, int y)
        {
            if(czy_moge_tu_cokolwiek(x, y) && czy_obok_jest_droga(x,y))
            {
                PowerPlant temp = new PowerPlant(x, y, policz_najmniejsza_odl(wierze_cisnien, x, y));

                mapa[x, y] = temp;
                elektrownie.Add(temp);
            }
        }
    }
}
