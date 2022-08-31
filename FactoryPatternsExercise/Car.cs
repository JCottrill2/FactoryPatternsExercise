using FactoryPatternsExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExercise1
{
    public class Car : IVehicle
    {
        public Car ()
        {

        }
        public void Drive()
        {
            Console.WriteLine("Vrooom, the car is driving!");
        }
    }
}
