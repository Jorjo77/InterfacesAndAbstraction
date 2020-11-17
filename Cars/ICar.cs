using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public interface ICar
    {
        public string Model { get; }
        public string Color { get; }

        public void Start();
        public void Stop();
    }
}
