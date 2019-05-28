using System;
namespace POCity.Properties
{
    public class PowerPlant : BasicService
    {
        public PowerPlant(int x, int y, double odl_do_wody)
            : base(x, y)
        {
            radius = 7;
            czy_ma_prad = true;
            czy_ma_wode = (odl_do_wody <= 7);
        }

        public override string ToString()
        {
            return "BP " + x.ToString() + " " + y.ToString();
        }
    }
    public class Water : BasicService
    {
        public Water(int x, int y)
            : base(x, y)
        {
            radius = 5;
        }

        public override string ToString()
        {
            return "BW " + x.ToString() + " " + y.ToString();
        }
    }
}
