using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Contracts
{
    interface IElectricCar : ICar
    {
        public int Battery { get; set; }
    }
}
