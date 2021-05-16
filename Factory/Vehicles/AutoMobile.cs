
namespace Factory.Vehicles {

    class AutoMobile : IVehicle
    {
        public void Accelerate()
        {
            System.Console.WriteLine("AutoMobile Moving");
        }

        public void Start()
        {
            System.Console.WriteLine("AutoMobile Started");
        }

        public void Stop()
        {
            System.Console.WriteLine("AutoMobile Stopped");
        }
    }


}