using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineParameters = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineParameters[0];
                int power = int.Parse(engineParameters[1]);

                Engine engine = new Engine();

                if (engineParameters.Length == 2)
                {
                    engine = new Engine
                    {
                        Model = model,
                        Power = power
                    };
                }
                else if (engineParameters.Length == 3)
                {
                    int displacement = 0;
                    if (int.TryParse(engineParameters[2], out displacement))
                    {
                        engine = new Engine
                        {
                            Model = model,
                            Power = power,
                            Displacement = displacement
                        };
                    }
                    else
                    {
                        string efficiency = engineParameters[2];
                        engine = new Engine
                        {
                            Model = model,
                            Power = power,
                            Displacement = displacement,
                            Efficiency = efficiency
                        };
                    }
                    
                }
                else if (engineParameters.Length == 4)
                {
                    int displacement = int.Parse(engineParameters[2]);
                    string efficiency = engineParameters[3];
                    engine = new Engine
                    {
                        Model = model,
                        Power = power,
                        Displacement = displacement,
                        Efficiency = efficiency
                    };
                }
                engines.Add(engine);

            }


            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carParameters = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = carParameters[0];
                

                Car car = new Car();
                Engine engine = engines.Find(e => e.Model == carParameters[1]);
                if (carParameters.Length == 2)
                {
                    car = new Car(carModel, engine);
                }
                else if (carParameters.Length == 3)
                {
                    int weight = 0;
                    if (int.TryParse(carParameters[2], out weight))
                    {
                        car = new Car(weight, carModel, engine);
                    }
                    else
                    {
                        string color = carParameters[2];
                        car = new Car(color, weight, carModel, engine);
                    }
                }
                else if (carParameters.Length == 4)
                {
                    int weight = int.Parse(carParameters[2]);
                    string color = carParameters[3];
                    car = new Car(color, weight, carModel, engine);
                }
                cars[i] = car;

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($" {car.Engine.Model}:");
                Console.WriteLine($"   Power: {car.Engine.Power}");

                if (car.Engine.Displacement > 0)
                {
                    Console.WriteLine($"   Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"   Displacement: n/a");
                }

                if (!(car.Engine.Efficiency is null))
                {
                    Console.WriteLine($"   Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"   Efficiency: n/a");

                }

                if (car.Weight > 0)
                {
                    Console.WriteLine($" Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($" Weight: n/a");
                }

                if (!(car.Color is null))
                {
                    Console.WriteLine($" Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($" Color: n/a");
                }

            }
        }


    }
}
