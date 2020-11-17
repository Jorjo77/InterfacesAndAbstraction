﻿using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IEngineer
    {
        public List<Repair> Repairs { get; }
    }
}
