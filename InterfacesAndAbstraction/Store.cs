using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction
{
    class Store
    {
        public void BuyShoe(Shoe shoe, User user)
        {
            decimal price = shoe.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Nqma kesh");
            }
            user.Money -= price;
        }
        public void BuyToothbrush(Toothbrush toothbrush, User user)
        {
            decimal price = toothbrush.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Nqma kesh");
            }
            user.Money -= price;
        }

        public void BuyMicrophone(Microphone microphone, User user)
        {
            decimal price = microphone.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Nqma kesh");
            }
            user.Money -= price;
        }
    }
}
