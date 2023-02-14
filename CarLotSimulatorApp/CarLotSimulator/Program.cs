using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car dodge = new Car();
            dodge.Year = 2006;
            dodge.Make = "Dodge";
            dodge.Model = "Challenger";
            dodge.EngineNoise = Car.MakeEngineNoise("loud");
            dodge.HonkNoise = Car.MakeHonkNoise("loud");
            dodge.IsDrivable = true;

            var ford = new Car()
            {
                Year = 1996,
                Make = "Ford",
                Model = "Pinto",
                EngineNoise = Car.MakeEngineNoise("soft"),
                HonkNoise = Car.MakeHonkNoise("soft"),
                IsDrivable = false,
            };

            var chevy = new Car(2020, "Chevy", "Camero", Car.MakeEngineNoise("loud"), Car.MakeHonkNoise("loud"), true);
            var carList = new List<Car> { dodge, ford, chevy };
            
            

            
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"Year: {vehicle.Year}\nMake: {vehicle.Make}\nModel: {vehicle.Model}\nEngine Noise: {vehicle.EngineNoise}\n" +
                    $"Horn Noise: {vehicle.HonkNoise}\nDrivable: {vehicle.IsDrivable}\n");
            }

            
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
