using System;
namespace POCity.Properties
{
    public class Power : BasicService
    {
        //radius = 7;
        public Power()
        {
            radius = 7;
        }

        public override string ToString()
        {
            return "BP " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
    public class Water : BasicService
    {
        public Water()
        {
            radius = 5;
        }
        public override string ToString()
        {
            return "BW " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
