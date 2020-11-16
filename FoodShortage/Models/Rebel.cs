using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, string age, string groupe)
        {
            Name = name;
            Age = age;
            Groupe = groupe;
        }

        public string  Name { get; set; }
        public string Age { get; set; }
        public string Groupe { get; set; }
        public int Food { get ; set ; }

        public void BuyFood()
        {
            this.Food+=5;
        }
    }
}
