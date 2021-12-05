using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StorageLease.Cruds
{
    public static class ValidationMethods
    {

        /* checks if ID is legal return true if it is or false if its not*/
        public static bool IsLegalId(this string text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length != 9)
                return false;

            foreach (char character in text)
            {
                if (character < '0' || character > '9')
                    return false;
            }

            return true;
        }

        /*this function return true if password is valud according to the standrats*/
        public static bool IsLegalPassword(string text)
        {
            /*This regex will enforce these rules: • At least one upper case english letter 
             * • At least one upper case
             * • At least one digit
               • Minimum 8 in length*/

            Regex regex = new Regex("(^?=.*?[0-9]).{8,}(?=.*?[A-Z])");
            return regex.Match(text).Success;
        }
        /* checks if email formal is legal, return true if it is or false if its not*/
        internal static bool IsLegalEmail(string email)
        {
            Regex regex = new Regex("(@)(.+)$");
            return regex.Match(email).Success;
        }
    }
}
