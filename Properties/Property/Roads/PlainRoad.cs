using System;
namespace POCity.Properties
{
    [Serializable]
    public class PlainRoad : Road
    {
        public PlainRoad(int x, int y)
            : base(x, y)
        {
            my_name = "\u21FF\u21FF";
        }
        public new static int GetRadius()
        {
            return 0;
        }
    }
}
