using FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Contracts
{
    public interface ICitizen : IBuyer
    {
        public string Name { get; }
        public string Age { get; }
    }
}
