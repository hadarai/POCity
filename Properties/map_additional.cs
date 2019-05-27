using System;
namespace POCity.Properties
{
    public partial class Map
    {
        private bool czy_moge_tu_cokolwiek(int x, int y)
        {
            return mapa[x, y] == null && x < 20 && x > 0 && y < 20 && y > 0;
        }

        private bool czy_moge_tu_droge(int x, int y)
        {
            return (mapa[x + 1, y] is Road) ||
                   (mapa[x, y + 1] is Road) ||
                   (mapa[x - 1, y] is Road) ||
                   (mapa[x, y - 1] is Road);
        }
    }
}
