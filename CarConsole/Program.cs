using Cars;
using Cars.Engines;
using System;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var petrolCar = new Car<PetrolEngine>();
            var dieselCar = new Car<DieselEngine>();
            var electricCar = new Car<ElectricEngine>();

            Console.WriteLine($"Starting petrol car: {petrolCar.Start()}");
            Console.WriteLine($"Starting diesel car: {dieselCar.Start()}");
            Console.WriteLine($"Starting electric car: {electricCar.Start()}");

            Console.WriteLine("\nPress <ENTER> to exit..");
            Console.ReadLine();
        }
    }
}
