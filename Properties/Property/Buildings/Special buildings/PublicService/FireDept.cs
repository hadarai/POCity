using System;
namespace POCity.Properties
{
    [Serializable]
    public class FireDept : SpecialBuilding
    {
        public FireDept(int x, int y)
            : base(x, y)
        {
            my_name = "\u26D1";
        }

        public new static int GetRadius()
        {
            return 10;
        }
    }
}
