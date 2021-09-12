using System;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car petrolCar = new Car("vroom");
            Car dieselCar = new Car("prut");
            Car electricCar = new Car("zoom");


            Car futureCar = new Car("future");


            Console.WriteLine($"Starting petrol car: {petrolCar.Start()}");
            Console.WriteLine($"Starting diesel car: {dieselCar.Start()}");
            Console.WriteLine($"Starting electric car: {electricCar.Start()}");

            Console.WriteLine("\nPress <ENTER> to exit..");
            Console.ReadLine();
        }
    }

    class Car
    {
        private readonly string sound = string.Empty;

        public string Start() => sound;

        public Car(string sound) => this.sound = sound;
    }
}

//Voordelen
// - Een toekomstige auto kan makkelijk aangemaakt worden door enkel een nieuwe geluid in de constructor mee te geven
          

//Nadelen
// - Het geluid resultaat van de auto/motor wordt door de program class bepaalt en deze zijn niet beperkt tot de in voorlopinge in de opdracht voorgeschreven geluiden
// - De 'geluiden' van gasgeven en stoppen zouden ook in de constructor van de auto gedaan moeten worden, dit worden vele parameters..
// - We hebben één auto definitie, voor alle verschillende soorten van auto's
// - Alleen aan het geluid kan afgeleid worden met welk type auto we te maken hebben