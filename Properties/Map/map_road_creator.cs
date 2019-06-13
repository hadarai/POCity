using System;
namespace POCity.Properties
{
    public partial class Map
    {
        public void PostawDroge(int x, int y, int Typ)
        {
            if (CzyMogeTuCokolwiek(x, y))
            {
                switch (Typ)
                {
                    case 0:
                        mapa[x, y] = new PlainRoad(x, y);
                        break;
                    case 1:
                        mapa[x, y] = new Avenue(x, y);
                        break;
                    case 2:
                        mapa[x, y] = new Highway(x, y);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
