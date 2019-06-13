using System;
using POCity.Properties;
//using System.Diagnostics;

namespace POCity {
    class MainClass {
        public static void Main (string[] args)
        {
            Console.WriteLine(ZoneBuilding.GetRadius());
            TextInterface interfejsGry = new TextInterface();
            interfejsGry.Run();

        }
    }
}