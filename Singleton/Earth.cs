using System;

class Earth : Planet
{

    private const double _EarthDiameter = 12742.0;     // in kilometers
    private const double _EarthWeight = 5.972E24;    // in kilograms

    private static readonly object _syncLock = new object(); // Thread sync lock

    private static Earth _Earth;
    public static Earth Instance
    {
        get
        {
            if (_Earth is not null)
            {
                return _Earth;
            }

            lock (_syncLock)
            {
                if (_Earth is null)
                {
                    _Earth = new Earth(_EarthDiameter, _EarthWeight);
                }
            }

            return _Earth;
        }
    }

    private Earth(double diameter, double weight) : base(diameter, weight) { }

    public override void CountHumanPopulationFromSatelliteData()
    {
        // Fancy satellite count
        Random random = new Random();
        int rand = random.Next(70, 80);
        _humanPopulation = (long)((rand + random.NextDouble()) * 10E8);

    }


}