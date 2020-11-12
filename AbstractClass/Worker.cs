using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Worker : IWorker//Така мап -ваме интерфейса към абстрактен клас
    {
        //в абстрактния клас можем да правим и пропъртита:
        public abstract int Salary { get; set; }
        public abstract void Work();//слагайки абстракт на метод, казваме че този метод трябва да се имплементира от класовете които наследяват абстракт класа, но тук не казваме каква е имплементацията! Имплементацията да си я правят децата както си искат!
        public void Slack()// и всеки един Worker слаква по един и същи начин!
        {
            Console.WriteLine("Slacking is cool!");
        }

        public void GetSalary()//Тук можем или ние да го имплементираме или на децата да кажем да го имплементират с abstract:
        {
            throw new NotImplementedException();
        }
        //public abstract void GetSalary(); - казваме на дацата да си го имплементират както си искат!!!
    }
}
