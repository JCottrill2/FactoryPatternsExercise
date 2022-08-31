using FactoryPatternsExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExercise1
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int seatCount)
        {
            switch (seatCount)
            {
                case 5:
                    return new Car();
                case 6:
                    return new Minivan();
                case 7:
                    return new Minivan();
                case 8:
                    return new Minivan();
                case 9:
                    return new Minivan();
                case 2:
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
