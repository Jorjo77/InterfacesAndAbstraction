using InterfacesAndAbstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction
{
    class Store
    {
        //Това е абстрактния начин да запишем закоментираните методи дилу (с един метод вършим работата на 3-те метода долу!
        public void BuyProduct(IPrice product, User user)//така подаден обекта, е скопен само до пропъртито Price, защото другите не ни интересуват!
        {
            decimal price = product.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Nqma kesh");
            }
            user.Money -= price;
            Console.WriteLine($"Bought: " + product + $"for only : {price}");
        }
        //И така целия този код долу стана излишен, защото с помощтта на IPrice метода горе работи за всички продукти!
        //public void BuyShoe(Shoe shoe, User user)
        //{
        //    decimal price = shoe.Price;
        //    if (user.Money < price)
        //    {
        //        throw new ArgumentException("Nqma kesh");
        //    }
        //    user.Money -= price;
        //}
        //public void BuyToothbrush(Toothbrush toothbrush, User user)
        //{
        //    decimal price = toothbrush.Price;
        //    if (user.Money < price)
        //    {
        //        throw new ArgumentException("Nqma kesh");
        //    }
        //    user.Money -= price;
        //}

        //public void BuyMicrophone(Microphone microphone, User user)
        //{
        //    decimal price = microphone.Price;
        //    if (user.Money < price)
        //    {
        //        throw new ArgumentException("Nqma kesh");
        //    }
        //    user.Money -= price;
        //}
    }
}
