using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    public interface IWorker
    {
        void Work();//тук и да не сложим публик автоматично, то си го слага, но по навик можем да си го слагаме (така прави Даков)!

        public void GetSalary();

    }
}
