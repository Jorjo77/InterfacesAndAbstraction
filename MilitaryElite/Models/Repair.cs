using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Repair
    {
        public Repair(string name, int workedHours)
        {
            Name = name;
            WorkedHours = workedHours;
        }

        public string Name { get; }
        public int WorkedHours { get; }
    }
}
