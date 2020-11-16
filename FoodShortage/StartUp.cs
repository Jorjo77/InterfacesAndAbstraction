using FoodShortage.Contracts;
using FoodShortage.Models;
using BorderControl.Contracts;
using BorderControl.Models;
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
            HashSet<Citizen> citizenCollection = new HashSet<Citizen>();
            HashSet<Rebel> rebelCollection = new HashSet<Rebel>();
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
                    citizenCollection.Add(citizen);
                }
                else if (splitedInput.Length == 3)
                {
                    string name = splitedInput[0];
                    string age = splitedInput[1];
                    string groupe = splitedInput[2];
                    Rebel rebel = new Rebel(name, age, groupe);
                    rebelCollection.Add(rebel);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }
                if (citizenCollection.FirstOrDefault(c=>c.Name==name)!=null)
                {
                    citizenCollection.First.BuyFood()
                }


                //collection.Where(x => x.Name==name)
                  //.Select(x => x.Birthdate)
                  //.ToList()
                  //.ForEach(Console.WriteLine);
            }



        }
    }
}
