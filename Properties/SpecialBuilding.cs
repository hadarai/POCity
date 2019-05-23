using System;
namespace POCity.Properties
{
    public class BasicService : SpecialBuilding
    {
        public override string ToString()
        {
            return "Jestem basic special " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }

    public class PublicService : SpecialBuilding
    {
        public override string ToString()
        {
            return "Jestem publicService special " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }

    public class OtherService : SpecialBuilding
    {
        public override string ToString()
        {
            return "Jestem other special " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
