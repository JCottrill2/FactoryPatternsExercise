using FactoryPatternsExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExercise1
{
    public class Minivan : IVehicle
    {
        public Minivan()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Beep, Beep! Lets go for a ride!");
        Console.WriteLine("Wheeeeee!");
        }
    }
}
