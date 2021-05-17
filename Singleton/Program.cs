using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Earth ourOneAndOnlyEarth = Earth.Instance;
            Earth theSameBigBlueEarth = Earth.Instance;

            ourOneAndOnlyEarth.CountHumanPopulationFromSatelliteData();

            System.Console.WriteLine(ourOneAndOnlyEarth.GetHumanPopulationFromSatelliteData());
            System.Console.WriteLine(theSameBigBlueEarth.GetHumanPopulationFromSatelliteData());
        }
    }
}
