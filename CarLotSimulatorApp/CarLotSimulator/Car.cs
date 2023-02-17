using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car() //creating defult constructor
        {
            CarLot.numberOfCars++;
        
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }                       //properties
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public static string MakeEngineNoise(string rumble)
        {
            if(rumble == "loud")
            {
                return "Rumbley";

            }
            else
            {
                return "Quiet";
            }
        }

        public static string MakeHonkNoise(string honk)
        {
            if (honk == "loud")
            {
                return "Loud";
            }
            else 
            {
                return "Soft";
            }
            
        }
        //Custom Class
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)//special member method
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }
    }
    
}
