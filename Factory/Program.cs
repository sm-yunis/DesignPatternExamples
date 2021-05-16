using Factory.Vehicles;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            IVehicle autoMobile = VehicleFactory.CreateVehicle(Vehicle.AutoMobile);

            autoMobile.Start();
            autoMobile.Accelerate();
            autoMobile.Stop();

            VehicleFactory truckFactory = new VehicleFactory(Vehicle.Truck);
            IVehicle truck = truckFactory.CreateVehicle();

            truck.Start();
            truck.Accelerate();
            truck.Stop();

            VehicleFactory genericFactory = new VehicleFactory();
            genericFactory.VehicleType = Vehicle.AutoMobile;
            IVehicle autoFromGenericFactory = genericFactory.CreateVehicle();

            genericFactory.VehicleType = Vehicle.Truck;
            IVehicle truckFromGenericFactory = genericFactory.CreateVehicle();


            System.Console.WriteLine("\nVehicles from a generic factory");
            autoFromGenericFactory.Start();
            autoFromGenericFactory.Accelerate();
            autoFromGenericFactory.Stop();

            truckFromGenericFactory.Start();
            truckFromGenericFactory.Accelerate();
            truckFromGenericFactory.Stop();

        }
    }
}
