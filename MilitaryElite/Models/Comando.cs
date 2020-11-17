using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class Comando : SpecialisedSoldier, IComando
    {
        //private List<Mission> missions;
        public Comando(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Missions = new List<Mission>();
        }
        public List<Mission> Missions { get; }
        public void CompleteMission()
        {
            Console.WriteLine("Finished");
        }
    }
}
