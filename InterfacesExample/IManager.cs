using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    interface IManager : IWorker
    {
        public List<IWorker> Team { get; set; }

    }
}
