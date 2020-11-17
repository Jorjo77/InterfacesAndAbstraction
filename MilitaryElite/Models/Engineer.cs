using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        //private List<Repair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Repairs = new List<Repair>();
        }
        public List<Repair> Repairs{ get; }
    }
}
