using System;

namespace CarConsole_V4
{
    class Program
    {
        static void Main(string[] args)
        {

            var petrolCar = new Car(new PetrolEngine());
            var dieselCar = new Car(new DieselEngine());
            var electricCar = new Car(new ElectricEngine());

            Console.WriteLine($"Starting petrol car: {petrolCar.Start()}");
            Console.WriteLine($"Starting diesel car: {dieselCar.Start()}");
            Console.WriteLine($"Starting electric car: {electricCar.Start()}");

            Console.WriteLine("\nPress <ENTER> to exit..");
            Console.ReadLine();
        }
    }

    abstract class EngineBase 
    {
        protected readonly string sound = string.Empty;
        public string Start() => sound;

        protected EngineBase(string sound) => this.sound = sound;
    }
    class Car
    {
        private readonly EngineBase engine = null;
        public Car(EngineBase engine)
        {
            this.engine = engine;
        }

        public string Start() => engine.Start();
    }


    class PetrolEngine: EngineBase
    {
        private const string petrolSound = "vroom";
        public PetrolEngine(): base(petrolSound) 
        {
        
        }
    }
    class DieselEngine: EngineBase
    {
        private const string dieselSound = "prut";
        public DieselEngine(): base(dieselSound) 
        {
        
        }
    }
    class ElectricEngine: EngineBase
    {
        private const string electricSound = "zoom";
        public ElectricEngine(): base(electricSound) 
        {
        
        }
    }
}
