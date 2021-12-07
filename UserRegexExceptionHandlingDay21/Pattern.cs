using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegexExceptionHandlingDay21
{
    class Pattern
    {
        public static string Regex_EmailId = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public bool ValidateEmailId(string EmailId)
        {
            return Regex.IsMatch(EmailId, Regex_EmailId);

        }
        public static void CheckEmail(string EmailId)
        {
            try
            {
                if (EmailId == String.Empty || EmailId == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(EmailId, Regex_EmailId) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid EmailId");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }
        }
    }
}
