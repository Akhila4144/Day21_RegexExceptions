using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegexExceptionHandlingUC5
{
    class Pattern
    {
        public static string Regex_Password = "^[A-Za-z]{8,}$";
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);

        }
        public static void CheckPassword(string Password)
        {
            try
            {
                if (Password == String.Empty || Password == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field  is empty ");
                }
                else if (Regex.IsMatch(Password, Regex_Password) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid Password. It should  contain atleast minimum 8 characters ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }
        }
    }
}