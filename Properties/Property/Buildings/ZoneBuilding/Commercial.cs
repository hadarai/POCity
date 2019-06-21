using System;
namespace POCity.Properties
{
    [Serializable]
    public class Commercial : ZoneBuilding
    {
        bool do_i_have_park { set; get; }

        public Commercial(int x, int y)
            : base(x, y)
        {
            my_name = "\u20AC ";
        }

        public override void GetToKnow(Type NewNeighbour) 
        {
            base.GetToKnow(NewNeighbour);
            if (NewNeighbour == typeof(Park))
            {
                do_i_have_park = true;
            }
        }

        public override string IsWorking()
        {
            if (do_i_have_power && do_i_have_water && do_i_have_police && do_i_have_fire && do_i_have_hospital && do_i_have_park)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public string GotPark()
        {
            if (do_i_have_park)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public new static int GetRadius()
        {
            return 0;
        }

        public override int WorthPoints()
        {
            if(IsWorking() == "\u2714")
            {
                return 4;
            }
            return 0;
        }
    }
}
