using System;
namespace AbstractExercise
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }
        public abstract void Drive(); //stubbed out method because it has no {}
        public int Wheels { get; set; }
        public int Doors { get; set; }

    }
}

