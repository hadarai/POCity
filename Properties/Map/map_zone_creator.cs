using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace POCity.Properties
{
    public partial class Map
    {
        private int dist(int x1, int y1, int x2, int y2)
        { return 4; }
        public void RaiseBuilding(int x, int y, string building_name)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                Type t = Type.GetType(building_name);

                object instance = Activator.CreateInstance(t, x, y);
                Building p = (Building)instance;
                mapa[x, y] = p;


                IEnumerable<Property> sasiedztwo = GetNeighbouringProperties(x, y);

                    //System.Exit
                foreach (Property somsiad in sasiedztwo)
                {
                    if (somsiad != null )
                    {
                        //Console.WriteLine(p);
                        //Console.Write(somsiad);
                        Console.Write(somsiad.GetType());
                        if ((int)somsiad.
                            GetType().
                            GetMethod("GetRadius", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.FlattenHierarchy
                             ).
                             Invoke(null, null) <= dist(p.x, p.y, somsiad.x, somsiad.y))
                        {

                            p.GetToKnow(somsiad.GetType());
                        }
                        Console.WriteLine("im done");
                    }


                }




                //foreach (Type a in p.wymagane_budynki)
                //{
                //    //int prom = (int)a.GetMethod("GetRadius").Invoke(null, null);
                //    //((Property)a).GetRadius();
                //    bool ble = NajkrotszaOdleglosc(Get_list_building_of_type(a), x, y) > 4;
                //}

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

            for (int i=-half_radius ; i < half_radius; i++)
            {
                if (i + x < 0 || i + x >= height) continue;
                for(int j=-half_radius;j < half_radius;j++)
                {
                    if (j + y < 0 || j+y >= width ) continue;
                    Neighbouring.Add(mapa[i + x, j + y]);
                }
            }
            return Neighbouring;
        }
        /*
        public void PostawDom(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                mapa[x, y] = new ResidentialBuilding(x, y,
                    NajkrotszaOdleglosc(WiezeCisnien, x, y) < PromienWody, 
                    NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu, 
                    NajkrotszaOdleglosc(Policje, x, y) < PromienPolicji,
                    NajkrotszaOdleglosc(StrazePozarne, x, y) < PromienStrazy,
                    NajkrotszaOdleglosc(Szpitale, x, y) < PromienSzpitala,
                    NajkrotszaOdleglosc(Parki, x, y) < PromienParku,
                    NajkrotszaOdleglosc(Szkoly, x, y) < PromienSzkoly);
            }
        }
        public void PostawSklep(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                mapa[x, y] = new CommercialBuilding(x, y,
                    NajkrotszaOdleglosc(WiezeCisnien, x, y) < PromienWody,
                    NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu,
                    NajkrotszaOdleglosc(Policje, x, y) < PromienPolicji,
                    NajkrotszaOdleglosc(StrazePozarne, x, y) < PromienStrazy,
                    NajkrotszaOdleglosc(Szpitale, x, y) < PromienSzpitala,
                    NajkrotszaOdleglosc(Parki, x, y) <PromienParku);

            }
        }
        public void PostawFabryke(int x, int y)
        {
            if (CzyMogeTuCokolwiek(x, y) && CzyObokJestDroga(x, y))
            {
                mapa[x, y] = new IndustrialBuilding(x, y,
                    NajkrotszaOdleglosc(WiezeCisnien, x, y) < PromienWody,
                    NajkrotszaOdleglosc(Elektrownie, x, y) < PromienPradu,
                    NajkrotszaOdleglosc(Policje, x, y) < PromienPolicji,
                    NajkrotszaOdleglosc(StrazePozarne, x, y) < PromienStrazy,
                    NajkrotszaOdleglosc(Szpitale, x, y) < PromienSzpitala);

            }
        }
        */
    }
}
