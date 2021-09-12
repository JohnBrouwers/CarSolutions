using System;

namespace CarConsole_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            PetrolCar petrolCar = new ();
            DieselCar dieselCar = new ();
            ElectricCar electricCar = new ();

            Console.WriteLine($"Starting petrol car: {petrolCar.Start()}");
            Console.WriteLine($"Starting diesel car: {dieselCar.Start()}");
            Console.WriteLine($"Starting electric car: {electricCar.Start()}");

            Console.WriteLine("\nPress <ENTER> to exit..");
            Console.ReadLine();
        }
    }

    abstract class CarBase
    {
        private readonly string sound = string.Empty;

        protected CarBase(string sound) => this.sound = sound;

        public string Start() => sound;
    }

    class PetrolCar : CarBase
    {
        private const string petrolSound = "vroom";

        public PetrolCar(): base(petrolSound)
        {

        }
    }
    class DieselCar : CarBase
    {
        private const string sound = "prut";

        public DieselCar(): base(sound)
        {

        }
    }
    class ElectricCar : CarBase
    {
        private const string sound = "zoom";

        public ElectricCar(): base(sound)
        {

        }
    }
}
//Voordelen
// - Iedere auto bevat alleen de code die nodig is voor het geluid
// - Er dient een nieuwe auto definitie gemaakt te worden voor elk nieuw type auto
// - Aan de auto classe is af te lezen met welke soort van auto we te maken hebben

//Nadelen
//In de opdracht is omschreven dat er één auto model is met verschillende motoren