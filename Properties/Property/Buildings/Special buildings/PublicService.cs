using System;
namespace POCity.Properties
{
    public class Healthcare : PublicService
    {
        public Healthcare(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "PH " + x.ToString() + " " + y.ToString();
        }
    }
    public class Police : PublicService
    {
        public Police(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "PP " + x.ToString() + " " + y.ToString();
        }
    }
    public class Fire : PublicService
    {
        public Fire(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "PF " + x.ToString() + " " + y.ToString();
        }
    }
}
