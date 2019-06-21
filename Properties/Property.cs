using System;

namespace POCity.Properties
{
    [Serializable]
    public abstract class Property
    {
        public int x;
        public int y;
        protected string my_name;

        protected Property(int new_x, int new_y)
        {
            x = new_x;
            y = new_y;
        }

        public override string ToString()
        {
            return this.my_name;
        }

        public static int GetRadius()
        {
            return 0;
        }

        public abstract void GetToKnow(Type new_neighbour);

        public abstract string IsWorking();
        public abstract string GotWater();
        public abstract string GotPower();

        public abstract int WorthPoints();
    }

}

