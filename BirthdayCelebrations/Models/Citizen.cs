using BirthdayCelebrations.Contracts;
using BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    public class Citizen : ICitizen, IBirthable
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
    }
}
