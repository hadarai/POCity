using System;
using System.Collections.Generic;

namespace POCity.Properties
{
    [Serializable]
    public class Building : Property
    {
        public bool do_i_have_water { get; set; }
        public bool do_i_have_power { get; set; }

        public List<Type> required_buildings = new List<Type>();

        protected Building(int x, int y)
            : base(x, y)
        {

            required_buildings.Add(typeof(PowerPlant));
            required_buildings.Add(typeof(WaterTower));
        }

        public override void GetToKnow(Type new_neighbour)
        {
            if (new_neighbour == typeof(PowerPlant))
            {
                do_i_have_power = true;
            }
            else if (new_neighbour == typeof(WaterTower))
            {
                do_i_have_water = true;
            }

        }

        public override string IsWorking()
        {
            if (do_i_have_power && do_i_have_water)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public override string GotWater()
        {
            if (do_i_have_water)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public override string GotPower()
        {
            if (do_i_have_power)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public override int WorthPoints()
        {
            return 0;
        }
    }
}
