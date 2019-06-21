using System;
namespace POCity.Properties
{
    [Serializable]
    public class Highway : Road
    {
        public Highway(int x, int y)
            : base(x, y)
        {
            my_name = "\u21C4\u21C4";
        }
        public new static int GetRadius()
        {
            return 0;
        }
    }
}
