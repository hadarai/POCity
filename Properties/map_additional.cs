using System;
using System.Collections.Generic;
namespace POCity.Properties
{
    public partial class Map
    {
        private bool CzyMogeTuCokolwiek(int x, int y)
        {
            return mapa[x, y] == null && x < 20 && x > 0 && y < 20 && y > 0;
        }

        private bool CzyObokJestDroga(int x, int y)
        {
            return (mapa[x + 1, y] is Road) ||
                   (mapa[x, y + 1] is Road) ||
                   (mapa[x - 1, y] is Road) ||
                   (mapa[x, y - 1] is Road);
        }

        private double NajkrotszaOdleglosc<T>(List<T> ListaBudynkow, int x, int y)
        {
            double Min = 500;

            System.Collections.IList list = ListaBudynkow;
            for (int i1 = 0; i1 < list.Count; i1++)
            {
                Property i = (Property)list[i1];
                double dist = Math.Sqrt((Math.Abs(i.x - x)) ^ 2 + (Math.Abs(y - i.y) ^ 2));
                if (dist < Min)
                {
                    Min = dist;
                }
            }
            return Min;
        }

    }
}
