using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class Boss : IManager
    {
        public List<IWorker> Team { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetSalary()
        {
            Console.WriteLine("A lot");
        }

        public void Work()
        {
            Console.WriteLine("Shefsva i micromanagement");
        }
    }
}
