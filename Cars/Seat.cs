using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

       
        public string Model { get ; private set ; }
        public string Color { get ; private set; }

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
            sb.AppendLine($"{this.Color} {nameof(Seat)}  {this.Model}");
            sb.AppendLine("Engine start");
            sb.AppendLine("Breaaak!");
            return sb.ToString().TrimEnd();  
        }
    }
}
