using System;
namespace POCity.Properties
{
    public class School : OtherService
    {
        public School(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "OS " + x.ToString() + " " + y.ToString();
        }
    }

    public class Park : OtherService
    {
        public Park(int x, int y)
            : base(x, y)
        { }

        public override string ToString()
        {
            return "OP " + x.ToString() + " " + y.ToString();
        }
    }
}
