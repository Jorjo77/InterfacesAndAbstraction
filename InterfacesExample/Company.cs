using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class Company
    {
        public List<IWorker> Workers { get; set; }//така възприемаме Boss, FactoryWorker, Worker като едно и също нещо.

        public Company()
        {
            Workers = new List<IWorker>();
        }
        public void WorkDay()
        {
            Workers.ForEach((worker) =>
            {
                if (worker is Programmer)//is е ключова думичка и проверява типа на един клас, дали този обект е от този тип
                {
                    Programmer programmer = (Programmer)worker; // можем да го кастнем по този начин и така вече имаме programmer с всичките му неща.
                    Console.WriteLine("Opaa, programistche");
                    programmer.PretendToBeSmart();//след кастването вече имаме и това пропърти (което си е на програмиста извън абстракцията). Това рядко се налага да се прави  (губи се абстракцията и по-скоро не е препоръчително)
                }
                worker.Work();
            });

        }

        public void SalaryDay()
        {
            Workers.ForEach((worker) =>
            {
                worker.GetSalary();
            });
        }
    }
}
