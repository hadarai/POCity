using System;
namespace POCity.Properties
{
    public class BasicService : SpecialBuilding
    {
        public BasicService(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "Jestem basic special " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }

    public class PublicService : SpecialBuilding
    {
        public PublicService(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "Jestem publicService special " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }

    public class OtherService : SpecialBuilding
    {
        public OtherService(int x, int y)
            : base(x, y)
        { }
        public override string ToString()
        {
            return "Jestem other special " + X.ToString() + " " + Y.ToString() + "\n";
        }
    }
}
