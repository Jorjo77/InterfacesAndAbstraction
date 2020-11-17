using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IComando
    {
        public List<Mission> Missions { get; }
        public void CompleteMission();
    }
}
