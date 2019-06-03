using System;
namespace POCity.Properties
{
    public class BasicService : SpecialBuilding
    {
        public BasicService(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        { }
        public override string ToString()
        {
            return "Jestem BasicSpecial" + x.ToString() + " " + y.ToString() + "\n";
        }
    }

    public class PublicService : SpecialBuilding
    {
        public PublicService(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        { }
        public override string ToString()
        {
            return "Jestem PublicServiceSpecial" + x.ToString() + " " + y.ToString() + "\n";
        }
    }

    public class OtherService : SpecialBuilding
    {
        public OtherService(int x, int y, bool MapaMowiOWodzie, bool MapaMowiOPradzie)
            : base(x, y, MapaMowiOWodzie, MapaMowiOPradzie)
        { }
        public override string ToString()
        {
            return "Jestem OtherSpecial" + x.ToString() + " " + y.ToString() + "\n";
        }
    }
}
