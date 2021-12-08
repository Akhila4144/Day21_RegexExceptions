using System;

namespace UserRegexExceptionHandlingUC_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string Password;
            Console.Write("Enter Password : ");
            Password = Console.ReadLine();
            Pattern.CheckPassword(Password);


            Console.ReadKey();
        }
    }
    
}
