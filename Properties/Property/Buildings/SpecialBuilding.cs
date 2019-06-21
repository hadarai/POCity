using System;
namespace POCity.Properties
{
    [Serializable]

    public class SpecialBuilding : Building
    {
        public SpecialBuilding(int x, int y)
            : base(x, y)
        { }

        public new static int GetRadius()
        {
            return 0;
        }

        public override string IsWorking()
        {
            if(do_i_have_power && do_i_have_water)
            {
                return "\u2714";
            }
            return "\u2718";
        }
    }
}
