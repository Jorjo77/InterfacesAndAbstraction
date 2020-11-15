using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exeptions;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string urls)
        {
            if (urls.Any(x => Char.IsDigit(x)))//ако имаш поне един тролни
            {
                throw new InvalidUrlException();
            }
            return $"Browsing: {urls}!";
        }
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => Char.IsDigit(x)))//ако всичките не са ти диджити, тогава тролни
            {
                throw new InvalidPhoneNumberException();
            }
           return $"Calling... {phoneNumber}";
        }
    }
}
