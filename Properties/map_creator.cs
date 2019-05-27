using System;
namespace POCity.Properties
{
    public partial class Map
    {
        public void postaw_droge(int x, int y, int typ)
        {
            if (czy_moge_tu_cokolwiek(x, y) && czy_moge_tu_droge(x, y))
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
    }
}
