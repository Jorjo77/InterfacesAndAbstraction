using MilitaryElite.Models;
using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ILieutenantGeneral
    {
        public List<Private> Privates { get; }
    }
}
