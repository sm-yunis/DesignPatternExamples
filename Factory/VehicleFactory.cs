
using Factory.Vehicles;

namespace Factory
{
    enum Vehicle
    {
        AutoMobile,
        Truck
    }

    class VehicleFactory
    {

        public Vehicle VehicleType { get; set; }

        public VehicleFactory()
        {
            
        }

        public VehicleFactory(Vehicle vehicleType)
        {
            VehicleType = vehicleType;
        }

        public static IVehicle CreateVehicle(Vehicle vehicleType) => vehicleType switch
        {
            Vehicle.AutoMobile => new AutoMobile(),
            Vehicle.Truck => new Truck(),
            _ => null
        };

        public IVehicle CreateVehicle()
        {
            return VehicleFactory.CreateVehicle(VehicleType);
        }


    }
}