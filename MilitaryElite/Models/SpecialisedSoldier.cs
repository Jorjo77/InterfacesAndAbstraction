using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string crops;
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            Crops = crops;
        }
        public string Crops 
        {
            get
            {
                return this.crops;
            }
            private set
            {
                if (value== "Airforces" || value == "Marines")
                {
                    this.crops = value; 
                }
            }
        }
    }
}
