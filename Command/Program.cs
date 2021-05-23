using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            Person johnDoe = new Person("John Doe", 25);
            System.Console.WriteLine("Being Productive...");
            controller.SetCommand(new BeProductiveCommand(johnDoe));
            controller.Invoke();

            System.Console.WriteLine("Goofing Off...");
            controller.SetCommand(new GoofOffCommand(johnDoe));
            controller.Invoke();


        }
    }
}
