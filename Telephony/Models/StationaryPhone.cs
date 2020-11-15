using System;
using System.Linq;
using Telephony.Exeptions;


namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x=>Char.IsDigit(x)))
            { 
                throw new InvalidPhoneNumberException();
            }
            return $"Dialing... {phoneNumber}";
        }
    }
}

