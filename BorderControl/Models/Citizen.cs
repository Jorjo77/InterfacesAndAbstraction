using BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    public class Citizen : ICitizen
    {
        public Citizen(string name, string age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; }

        public string Age { get; }

        public string Id { get; }
    }
}
