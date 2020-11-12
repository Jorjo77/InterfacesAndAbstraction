using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Programmer : Worker
    {
        public override int Salary { get; set; }//и пропъртито трябва да оверрайднем (рядко се използва)!
        public override void Work()//не е като при интерфейсите просто да имплементираме метода Work(), а да го оверрайднем (така правим собствена имплементация на метода void Work()).
        {
            Console.WriteLine("Ne rabotq dneska");
        }
    }
}
