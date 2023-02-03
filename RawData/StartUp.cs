using System;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carsInformation = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = carsInformation[0];
                int engineSpeed = int.Parse(carsInformation[1]);
                int enginePower = int.Parse(carsInformation[2]);
                int cargoWeight = int.Parse(carsInformation[3]);
                string cargoType = carsInformation[4];
                float tyre1Pressure = float.Parse(carsInformation[5]);
                int tyre1Age = int.Parse(carsInformation[6]);
                float tyre2Pressure = float.Parse(carsInformation[7]);
                int tyre2Age = int.Parse(carsInformation[8]);
                float tyre3Pressure = float.Parse(carsInformation[9]);
                int tyre3Age = int.Parse(carsInformation[10]);
                float tyre4Pressure = float.Parse(carsInformation[11]);
                int tyre4Age = int.Parse(carsInformation[12]);

                Car car = new Car(carModel,engineSpeed,enginePower,cargoWeight,
                   cargoType,tyre1Pressure,tyre1Age,tyre2Pressure,tyre2Age,
                   tyre3Pressure,tyre3Age,tyre4Pressure,tyre4Age);
                cars[i] = car;
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "fragile"))
                {
                    if (car.Tyres.Any(t => t.TyrePressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                
            }
            else if (command == "flammable")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }

        }
    }
}
