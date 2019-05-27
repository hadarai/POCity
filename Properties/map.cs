using System;
namespace POCity.Properties
{
    public class Map
    {
        Property[,] mapa = new Property[20, 20];

        public Map()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mapa[i, j] = null;
                }
            }
        }

        public void zawolaj_to_string(int x, int y)
        {
            Console.WriteLine(mapa[x, y].ToString());
        }
    }
}
