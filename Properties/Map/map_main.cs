using System;
using System.Collections.Generic;
using System.Reflection;

namespace POCity.Properties
{
    public partial class Map
    {
        public int height { get; } = 20;
        public int width { get; } = 20 ;

        Property[,] map;

        public Map()
        {
            map = new Property[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[i, j] = null;
                }
            }
        }

        public string CallToString(int x, int y)
        {
            if (map[x, y] == null)
            {
                return "  ";
            }
            else
            {
                return map[x, y].ToString();
            }
        }

        public string RaiseBuilding(int x, int y, string building_name)
        {
            string info = null;
            if (CanIBuildHere(x, y) && AmINextToRoad(x, y))
            {
                Type t = Type.GetType(building_name);
                Property p;
                try
                {
                    object instance = Activator.CreateInstance(t, x, y);
                    p = (Property)instance;
                    map[x, y] = p;
                }
                catch (Exception e)
                {
                    if (e is System.ArgumentNullException || e is System.NullReferenceException)
                    {
                        throw new Exceptions.UnableToBuild();
                    }
                    return info;
                }

                info = "Zbudowano: " + p;

                IEnumerable<Property> sasiedztwo = GetNeighbouringProperties(x, y);

                foreach (Property somsiad in sasiedztwo)
                {
                    if (somsiad != null)
                    {

                        if ((int)somsiad.GetType().GetMethod("GetRadius", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.FlattenHierarchy).Invoke(null, null) >= dist(p.x, p.y, somsiad.x, somsiad.y))
                        {
                            p.GetToKnow(somsiad.GetType());
                        }
                        if((int)p.GetType().GetMethod("GetRadius", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.FlattenHierarchy).Invoke(null, null) >= dist(p.x, p.y, somsiad.x, somsiad.y))
                        {
                            somsiad.GetToKnow(p.GetType());
                        }
                    }
                }
            }
            else
            {
                throw new Exceptions.UnableToBuild();
            }
            return info;
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
                    Neighbouring.Add(map[i + x, j + y]);
                }
            }
            return Neighbouring;
        }

        public int CountPoints()
        {
            int sum = 0;
            for(int i=0;i<height;i++)
            {
                for(int j=0;j<width;j++)
                {
                    if(map[i,j] != null)
                    {
                        sum = sum + map[i, j].WorthPoints();
                    }
                }
            }
            return sum;
        }
        public List<string> TellAbout(int x, int y)
        {
            var data_info = new List<string>();
            try
            {
                string informations = map[x, y].GetType().ToString();
                string[] informations_split = informations.Split('.');
                data_info.Add(informations_split[2]);
                if(map[x,y] is Building)
                {
                    data_info.Add(map[x, y].IsWorking());
                    data_info.Add(map[x, y].GotPower());
                    data_info.Add(map[x, y].GotWater());

                    if(map[x,y] is ZoneBuilding)
                    {
                        ZoneBuilding newe = (ZoneBuilding)map[x, y];
                        data_info.Add(newe.GotPolice());
                        data_info.Add(newe.GotFire());
                        data_info.Add(newe.GotHospital());

                        if(map[x,y] is Commercial)
                        {
                            Commercial newe2 = (Commercial)map[x, y];
                            data_info.Add(newe2.GotPark());
                        }
                        else if(map[x,y] is Residential)
                        {
                            Residential newe3 = (Residential)map[x, y];
                            data_info.Add(newe3.GotPark());
                            data_info.Add(newe3.GotSchool());
                        }
                    }
                }
            }
            catch (System.NullReferenceException e)
            {
                data_info.Add("Empty Field");
            }
            return data_info;
        }
    }
}
