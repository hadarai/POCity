using System;
namespace POCity.Properties
{
    [Serializable]
    public class School : SpecialBuilding
    {
        public School(int x, int y)
            : base(x, y)
        {
            my_name = "\u266B ";
        }

        public new static int GetRadius()
        {
            return 6;
        }

    }
}
