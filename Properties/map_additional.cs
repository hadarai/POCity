using System;
using System.Collections.Generic;
namespace POCity.Properties
{
    public partial class Map
    {
        private bool czy_moge_tu_cokolwiek(int x, int y)
        {
            return mapa[x, y] == null && x < 20 && x > 0 && y < 20 && y > 0;
        }

        private bool czy_obok_jest_droga(int x, int y)
        {
            return (mapa[x + 1, y] is Road) ||
                   (mapa[x, y + 1] is Road) ||
                   (mapa[x - 1, y] is Road) ||
                   (mapa[x, y - 1] is Road);
        }

        private double policz_najmniejsza_odl<T>(List<T> someList, int x, int y)
        {
            double min = 500;
            if (typeof(T) == typeof(Water))
            {

                System.Collections.IList list = someList;
                for (int i1 = 0; i1 < list.Count; i1++)
                {
                    Property i = (Property)list[i1];
                    double dist = Math.Sqrt((Math.Abs(i.x - x)) ^ 2 + (Math.Abs(y - i.y) ^ 2));
                    //Console.WriteLine("kuupa" + i.y + i.x);
                    if (dist < min) min = dist;
                    //Console.WriteLine(dist);
                }

                // etc
            }
            //Console.WriteLine(min);
            return min;
        }
        

    }
}
