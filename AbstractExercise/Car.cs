using System;
namespace AbstractExercise
{
    public class Car : Vehicle
    {
        public Car()
        {
            Wheels = 4;
            Doors = 4;
        }
        public override void Drive()
        {

            Console.WriteLine($"A car drives with {Wheels} wheels and has {Doors} doors.");
        }

        
        
        
    }
}
