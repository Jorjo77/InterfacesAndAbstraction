using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Battery { get; private set; }

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {nameof(Tesla)}  {this.Model} with {this.Battery} Batteries");
            sb.AppendLine("Engine start");
            sb.AppendLine("Breaaak!");
            return sb.ToString().TrimEnd();
        }
    }
}
