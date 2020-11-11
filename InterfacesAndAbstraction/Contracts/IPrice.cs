using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction.Contracts
{
    public interface IPrice
    {
        public decimal Price { get; }//ако някой наследява IPrice, то той задължително трябва да има пропърти Price! Интерфейса не споменаа нищо за имплементация, той просто казва какво трябва да има, a кото го наследява ще си напави имплементацията!

        //void CalculatePrice();
    }
}
