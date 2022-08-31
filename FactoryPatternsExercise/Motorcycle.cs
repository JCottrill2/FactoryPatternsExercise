﻿using FactoryPatternsExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExercise1
{
    internal class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }
        public void Drive()
        {
            Console.WriteLine("The Motorcyle is revving up!");
            Console.WriteLine("Zooooooom!");
        }
    }


}
