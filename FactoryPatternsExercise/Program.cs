using FactoryPatternsExercise1;
using System;

namespace FactoryPatternsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
                int seatCount;
            bool input = false;
            do
            {
                Console.WriteLine("How many seats would you like in your vehicle?");

                 input = int.TryParse(Console.ReadLine(), out seatCount);
            }
            while (!input); 

           var vehicle = VehicleFactory.GetVehicle(seatCount);
            vehicle.Drive();
        }
    }
}