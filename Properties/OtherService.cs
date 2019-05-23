using System;
namespace POCity.Properties
{
    public class School : OtherService
    {
        public override string ToString()
        {
            return "OS " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }

    public class Park : OtherService
    {
        public override string ToString()
        {
            return "OP " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
