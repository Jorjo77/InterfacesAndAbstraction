using Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Car : ICar
    {
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get ; set ; }
        public string Color { get ; set ; }

        public void Start()
        {
            Console.WriteLine("Engine start"); 
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!"); 
        }

        public override string ToString()
        {
            return $"{Color} {Car.GetType} {Model}";
        }
    }
}
