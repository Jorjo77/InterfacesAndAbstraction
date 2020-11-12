using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker(); //тук гърми защото опитваме да инициализираме AbstractClass
            Worker worker1 = new Programmer();
            worker1.Work();//и това ще работи както работи програмиста

        }
    }
}
