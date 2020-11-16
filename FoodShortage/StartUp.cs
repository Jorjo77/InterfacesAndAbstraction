using FoodShortage.Contracts;
using FoodShortage.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBuyer> collection = new List<IBuyer>();

            int peopleNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleNumber; i++)
            {
                string input= Console.ReadLine();
                string[] splitedInput = input.Split();
                if (splitedInput.Length == 4)
                {
                    string name = splitedInput[0];
                    string age = splitedInput[1];
                    string id = splitedInput[2];
                    string birthdate = splitedInput[3];
                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    collection.Add(citizen);
                }
                else if (splitedInput.Length == 3)
                {
                    string name = splitedInput[0];
                    string age = splitedInput[1];
                    string groupe = splitedInput[2];
                    Rebel rebel = new Rebel(name, age, groupe);
                    collection.Add(rebel);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }
                var buyer = collection.SingleOrDefault(b => b.Name == name);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }

            }
            Console.WriteLine(collection.Sum(b=>b.Food));
        }
    }
}
