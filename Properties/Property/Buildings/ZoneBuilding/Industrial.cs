using System;
namespace POCity.Properties
{
    [Serializable]
    public class Industrial : ZoneBuilding
    {
        public Industrial(int x,
                                  int y)
            : base(x, y)
        {
            my_name = "\u2692 ";
        }

        public new static int GetRadius()
        {
            return 0;
        }

        public override string IsWorking()
        {
            if (do_i_have_power && do_i_have_water && do_i_have_police && do_i_have_fire && do_i_have_hospital)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public override int WorthPoints()
        {
            if (IsWorking() == "\u2714")
            {
                return 3;
            }
            return 0;
        }
    }
}
