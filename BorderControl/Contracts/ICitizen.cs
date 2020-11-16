using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Contracts
{
    public interface ICitizen : IDable
    {
        public string Name { get; }
        public string Age { get; }
    }
}
