using System;
namespace POCity.Properties
{
    public class Healthcare : PublicService
    {
        
        public override string ToString()
        {
            return "PH " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class Police : PublicService
    {
        public override string ToString()
        {
            return "PP " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class Fire : PublicService
    {
        public override string ToString()
        {
            return "PF " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
