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
// - Een toekomstige auto kan makkelijk aangemaakt worden door enkel een nieuwe 'sound' waarde in de constructor mee te geven
// - De uitbreiding van gasgeven en stoppen zou via de constructor van de auto gedaan moeten worden
          

//Nadelen
// - Het resultaat van de auto/motor wordt door de program bepaald en deze zijn niet beperkt tot de voorgeschreven geluiden
// - We hebben één auto definitie, voor alle verschillende soorten van auto's
// - Alleen aan het geluid kan afgeleid worden met welk type auto we te maken hebben