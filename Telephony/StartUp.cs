using System;
using Telephony.Models;
using Telephony.Exeptions;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split();
            string[] urls = Console.ReadLine()
                .Split();

            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                try
                {
                    if (phoneNumbers[i].Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(phoneNumbers[i]));
                    }
                    else if (phoneNumbers[i].Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(phoneNumbers[i])); 
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {

                    Console.WriteLine(ex.Message); 
                }
 
            }

            for (int i = 0; i < urls.Length; i++)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(urls[i]));
                }
                catch (InvalidUrlException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
