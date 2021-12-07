using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegexExceptionHandlingUC_2
{
    class Pattern
    {
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";


        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);

        }
        public static void checkLastName(string LastName)
        {
            try
            {
                if (LastName == String.Empty || LastName == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(LastName, Regex_LastName) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid LastName please check the first letter ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }

        }
    }
}
    