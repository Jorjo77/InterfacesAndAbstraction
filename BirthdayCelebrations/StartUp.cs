using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;
using BorderControl.Contracts;
using BorderControl.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> collection = new List<IBirthable>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] splitedInput = input.Split();
                if (splitedInput.Length == 5)
                {
                    string inputType = splitedInput[0];
                    string name = splitedInput[1];
                    string age = splitedInput[2];
                    string id = splitedInput[3];
                    string birthdate = splitedInput[4];
                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    collection.Add(citizen);
                }
                else if (splitedInput.Length == 3 && splitedInput[0] =="Pet")
                {
                    string name = splitedInput[1];
                    string birthdate = splitedInput[2];
                    Pet pet = new Pet(name, birthdate);
                    collection.Add(pet);
                }
            }
            string date = Console.ReadLine();
            collection.Where(x => x.Birthdate.EndsWith(date))
                .Select(x => x.Birthdate)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
