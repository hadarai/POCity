using System;
using System.Collections.Generic;
using System.Reflection;

namespace POCity.Properties
{
    public partial class Map
    {
        protected int height { get; } = 20;
        protected int width { get; } = 20 ;

        Property[,] mapa;// = new Property[height, width];

        //private List<PowerPlant> Elektrownie = new List<PowerPlant>();
        //public List<WaterTower> WiezeCisnien = new List<WaterTower>();

        //public List<PoliceStation> Policje = new List<PoliceStation>();
        //public List<FireDept> StrazePozarne = new List<FireDept>();
        //public List<Healthcare> Szpitale = new List<Healthcare>();

        //public List<Park> Parki = new List<Park>();
        //public List<School> Szkoly = new List<School>();


        public Map()
        {
            mapa = new Property[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    mapa[i, j] = null;
                }
            }
        }

        public string ZawolajToString(int x, int y)
        {
            if (mapa[x, y] == null)
            {
                return "  ";
            }
            else
            {
                return mapa[x, y].ToString();
            }
        }

        //public void ZawolajToUpdate(int x, int y)
        //{
        //    if (mapa[x, y] != null)
        //    {
        //    }
        //}

        


        public void RaiseBuilding(int x, int y, string building_name)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                Type t = Type.GetType(building_name);
                //Console.WriteLine("Zbuduje: " + building_name);
                object instance = Activator.CreateInstance(t, x, y);
                Property p = (Property)instance;
                mapa[x, y] = p;

                Console.WriteLine("Buduje: " + p);

                IEnumerable<Property> sasiedztwo = GetNeighbouringProperties(x, y);

                foreach (Property somsiad in sasiedztwo)
                {
                    if (somsiad != null)
                    {
                        //Console.WriteLine(p);
                        //Console.Write(somsiad);
                        //Console.Write(somsiad.GetType());

                        //Console.WriteLine("Sasiaduje z: " + somsiad);
                        //Console.WriteLine("ble: " + (int)somsiad.GetType().GetMethod("GetRadius", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.FlattenHierarchy).Invoke(null, null));

                        if ((int)somsiad.GetType().GetMethod("GetRadius", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.FlattenHierarchy).Invoke(null, null) >= dist(p.x, p.y, somsiad.x, somsiad.y))
                        {
                            Console.WriteLine("Blisko ja: " + p + " mam do: " + somsiad);
                            p.GetToKnow(somsiad.GetType());


                        }
                        if((int)p.GetType().GetMethod("GetRadius", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.FlattenHierarchy).Invoke(null, null) >= dist(p.x, p.y, somsiad.x, somsiad.y))
                        {
                            Console.WriteLine("Blisko on: " + somsiad + " ma do mnie: " + p);
                            somsiad.GetToKnow(p.GetType());
                        }
                        //Console.WriteLine("im done");
                    }
                }
            }
            else
            {
                throw new Exceptions.UnableToBuild();
            }
        }

        public IEnumerable<Property> GetNeighbouringProperties(int x, int y, int radius = 10)
        {
            int half_radius = radius / 2;

            List<Property> Neighbouring = new List<Property>();

            for (int i = -half_radius; i < half_radius; i++)
            {
                if (i + x < 0 || i + x >= height) continue;
                for (int j = -half_radius; j < half_radius; j++)
                {
                    if (j + y < 0 || j + y >= width) continue;
                    Neighbouring.Add(mapa[i + x, j + y]);
                }
            }
            return Neighbouring;
        }

    }
}
