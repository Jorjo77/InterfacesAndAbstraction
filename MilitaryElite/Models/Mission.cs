using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string state;

        public Mission(string name, string state)
        {
            Name = name;
            State = state;
        }

        public string Name { get; }
        public string State 
        { 
            get
            {
                return state;
            } set
            {
                if (value== "inProgress" || value == "Finished")
                {
                    this.state = value;
                }
            }
        }
    }
}
