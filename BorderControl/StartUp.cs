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
            List<IDable> collection = new List<IDable>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] splitedInput = input.Split();
                if (splitedInput.Length==3)
                {
                    string citizenName = splitedInput[0];
                    string age = splitedInput[1];
                    string id = splitedInput[2];
                    Citizen citizen = new Citizen(citizenName, age, id);
                    collection.Add(citizen);
                }
                else if (splitedInput.Length == 2)
                {
                    string model = splitedInput[0];
                    string id = splitedInput[1];
                    Robot robot = new Robot(model, id);
                    collection.Add(robot);
                }
            }
            string endDigits = Console.ReadLine();
            collection.Where(x => x.Id.EndsWith(endDigits))
                .Select(x => x.Id)
                .ToList()
                .ForEach(Console.WriteLine);

            //foreach (var item in collection) - 40 % хващам с този код!?
            //{
            //    int startSymbol = item.Id.Length - 3;
            //    string searchedId = item.Id.Substring(startSymbol);
            //    if (searchedId == endDigits)
            //    {
            //        Console.WriteLine(item.Id);
            //    }
            //}
        }
    }
}
