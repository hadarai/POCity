using System;
using System.Collections.Generic;

namespace POCity.Properties
{
    [Serializable]
    public partial class Map
    {
        private bool CanIBuildHere(int x, int y)
        {
            return map[x, y] == null;
        }

        private bool AmINextToRoad(int x, int y)
        {
            bool t1=false, t2=false, t3=false, t4=false;
            if(x < 19)
            {
                t1 = (map[x + 1, y] is Road);
            }
            if(y < 19)
            {
                t2 = (map[x, y + 1] is Road);
            }
            if(x > 0)
            {
                t3 = (map[x - 1, y] is Road);
            }
            if(y > 0)
            {
                t4 = (map[x, y - 1] is Road);
            }
            return t1 || t2 || t3 || t4;
        }

        private double dist(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((Math.Abs(x1 - x2)) ^ 2 + (Math.Abs(y1 - y2) ^ 2)); ; 
            }
        
        private double ShortestDistance(IEnumerable<Property> list_of_buildings, int x, int y)
        {
            double Min = 500;

            foreach(Property i in list_of_buildings)
            {
                double dist = Math.Sqrt((Math.Abs(i.x - x)) ^ 2 + (Math.Abs(y - i.y) ^ 2));
                if (dist < Min)
                {
                    Min = dist;
                }
            }
            return Min;
        }

        public void ForceRaiseHighway(int x, int y)
        {
            map[x, y] = new Highway(x, y);
        }

        private double ShortestDistance<T>(List<T> list_of_buildings, int x, int y)
        {
            double Min = 500;

            System.Collections.IList list = list_of_buildings;
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
