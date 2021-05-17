
abstract class Planet {

    private readonly double _diameter;
    private readonly double _weight;
    protected long _humanPopulation = default;

    protected Planet(double diameter,double weight){
        _diameter = diameter;
        _weight = weight;
    }

    public double GetDiameter() => _diameter;
    public double GetWeight() => _weight;
    public long GetHumanPopulationFromSatelliteData() => _humanPopulation;
    public abstract void CountHumanPopulationFromSatelliteData();

}