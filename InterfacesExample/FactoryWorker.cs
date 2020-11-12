using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class FactoryWorker : IWorker
    {
        public void GetSalary()
        {
            Console.WriteLine("Can get more"); ;
        }

        public void Work()
        {
            Console.WriteLine("Husseling hard"); ;
        }
    }
}
