using System;
namespace POCity.Properties
{
    [Serializable]
    public class ZoneBuilding : Building
    {
        protected bool do_i_have_police { get; set; }
        protected bool do_i_have_fire { get; set; }
        protected bool do_i_have_hospital { get; set; }

        public ZoneBuilding(int x, int y)
            : base(x, y)
        { }

        public override void GetToKnow(Type NewNeighbour)
        {
            base.GetToKnow(NewNeighbour);

            if (NewNeighbour == typeof(Hospital))
            {
                do_i_have_hospital = true;
            }
            if (NewNeighbour == typeof(PoliceStation))
            {
                do_i_have_police = true;
            }
            if (NewNeighbour == typeof(FireDept))
            {
                do_i_have_fire = true;
            }
        }

        public string GotPolice()
        {
            if (do_i_have_police)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public string GotFire()
        {
            if (do_i_have_fire)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public string GotHospital()
        {
            if (do_i_have_hospital)
            {
                return "\u2714";
            }
            return "\u2718";
        }

        public new static int GetRadius()
        {
            return 0;
        }

    }
}
