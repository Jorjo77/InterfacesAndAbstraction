using BirthdayCelebrations.Contracts;
using BorderControl.Contracts;
using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Citizen : ICitizen
    {
        public Citizen(string name, string age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; }

        public string Age { get; }

        public string Id { get; }

        public string Birthdate { get; }
        public int Food { get ; set ; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
