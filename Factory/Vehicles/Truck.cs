namespace Factory.Vehicles {

    class Truck : IVehicle {

        public void Start() {
            System.Console.WriteLine("Truck Stared");
        }

        public void Stop()
        {
            System.Console.WriteLine("Truck Stopped");
        }

        public void Accelerate()
        {
            System.Console.WriteLine("Truck Moving");
        }

    }
}