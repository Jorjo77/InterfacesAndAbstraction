using System;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            company.Workers.Add(new Programmer());
            company.Workers.Add(new Programmer());
            company.Workers.Add(new Boss());
            company.Workers.Add(new Boss());
            company.Workers.Add(new FactoryWorker());
            company.Workers.Add(new Boss());
            company.Workers.Add(new Intern());

            while (true)
            {
                var input = Console.ReadLine();
                company.WorkDay();
                if (input == "Salary")
                {
                    company.SalaryDay();
                }
            }
        }
    }
}
