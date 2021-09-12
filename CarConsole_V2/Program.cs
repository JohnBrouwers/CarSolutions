using System;

namespace CarConsole_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car petrolCar = new (Car.Type.Petrol);
            Car dieselCar = new (Car.Type.Diesel);
            Car electricCar = new (Car.Type.Electric);

            //Car futureCar = new Car(Car.Type....);


            Console.WriteLine($"Starting petrol car: {petrolCar.Start()}");
            Console.WriteLine($"Starting diesel car: {dieselCar.Start()}");
            Console.WriteLine($"Starting electric car: {electricCar.Start()}");


            Console.WriteLine("\nPress <ENTER> to exit..");
            Console.ReadLine();
        }
    }


    class Car
    {
        public enum Type 
        {
            Petrol,
            Diesel,
            Electric
        }

        private readonly string sound = string.Empty;

        private const string petrolSound = "vroom";
        private const string dieselSound = "prut";
        private const string electricSound = "zoom";

        public string Start() => sound;

        public Car(Type carType) => sound = carType switch
        {
            Type.Petrol => petrolSound,
            Type.Diesel => dieselSound,
            Type.Electric => electricSound,
            _ => throw new NotImplementedException(),
        };

        //bovenstaande is zelfde als

        //public Car(Type cartype)
        //{
        //    switch (cartype)
        //    {
        //        case Type.Petrol:
        //            sound = "vroom";
        //            break;
        //        case Type.Diesel:
        //            sound = "prut";
        //            break;
        //        case Type.Electric:
        //            sound = "zoom";
        //            break;
        //        default:
        //            throw new NotImplementedException($"CarType {nameof(cartype)} missing");
        //    }
        //}
    }
}

//Voordelen
// - In de program class kies je een type motor/auto en wordt je beperkt door de in de enum opgenomen opties 


//Nadelen
// - Om een toekomstige auto te maken moet er een nieuwe enum optie en contructor expression aangemaakt worden
// - De auto bevat code voor alle soorten van auto's en is dus tegelijkertijd een benzine, diesel electrische auto, terwijl nooit alle code tegelijkertijd gebruikt kan worden...