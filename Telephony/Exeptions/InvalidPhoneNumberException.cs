using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exeptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string INVALIDE_PHONENUMBER_EXCEPTION_MESSAGE = "Invalid number!";
        public InvalidPhoneNumberException()
            : base(INVALIDE_PHONENUMBER_EXCEPTION_MESSAGE)
        {

        }
    }
}
