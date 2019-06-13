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

        private double dist(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((Math.Abs(x1 - x2)) ^ 2 + (Math.Abs(y1 - y2) ^ 2)); ; 
            }

        public bool Szczescie(int x, int y)
        {
            return mapa[x, y].AmIHappy();
        }

        public bool CzyMaszWode(int x, int y)
        {
            return mapa[x, y].AmIWater();
        }
        public bool CzyMaszPrad(int x, int y)
        {
            return mapa[x, y].AmIPower();
        }

        //public IEnumerable<Property> Get_list_building_of_type(Type building_type)
        //{
        //    if (building_type == typeof(PowerPlant))
        //    {
        //        return Elektrownie;
        //    }
        //    if (building_type == typeof(WaterTower))
        //    {
        //        return WiezeCisnien;
        //    }
        //    if (building_type == typeof(Healthcare))
        //    {
        //        return Szpitale;
        //    }
        //    if (building_type == typeof(PoliceStation))
        //    {
        //        return Policje;
        //    }
        //    if (building_type == typeof(FireDept))
        //    {
        //        return StrazePozarne;
        //    }
        //    if (building_type == typeof(School))
        //    {
        //        return Szkoly;
        //    }
        //    if (building_type == typeof(Park))
        //    {
        //        return Parki;
        //    }
        //    return null;
        //}

        private double NajkrotszaOdleglosc(IEnumerable<Property> ListaBudynkow, int x, int y)
        {
            double Min = 500;
            //System.Collections.IList list = ListaBudynkow;
            foreach(Property i in ListaBudynkow)
            {
                //Property i = (Property)item;
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
            mapa[x, y] = new Highway(x, y);
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
