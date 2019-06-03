using System;
namespace POCity.Properties
{
    public class School : OtherService
    {
        public School(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        { }
        public override string ToString()
        {
            return "OS";// + x.ToString() + " " + y.ToString();
        }
    }

    public class Park : OtherService
    {
        public Park(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        { }

        public override string ToString()
        {
            return "OP";// + x.ToString() + " " + y.ToString();
        }
    }
}
