using System;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(); //instantiate
            car.Drive(); //used dot notation to call the method. polymorphism

            var motorcycle = new Motorcycle();//instantiate
            motorcycle.Drive(); ////used dot notation to call the method. polymorphism
        }
    }
}
