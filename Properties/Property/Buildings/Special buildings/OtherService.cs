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
            return "OS " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }

    public class Park : OtherService
    {
        public Park(int x, int y)
            : base(x, y)
        { }

        public override string ToString()
        {
            return "OP " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
