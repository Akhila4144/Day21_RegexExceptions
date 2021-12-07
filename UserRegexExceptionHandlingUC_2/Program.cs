using System;

namespace UserRegexExceptionHandlingUC_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration  ");
            string Lastname;
            Console.Write("Enter Last Name : ");
            Lastname = Console.ReadLine();
            Pattern.checkLastName(Lastname);
            Console.ReadKey();
        }
    }
}