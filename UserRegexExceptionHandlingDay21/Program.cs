using System;

namespace UserRegexExceptionHandlingDay21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration  ");
            string EmailId;
            Console.Write("Enter  Email Id  :");
            EmailId = Console.ReadLine();
            Pattern.CheckEmail(EmailId);
            Console.ReadKey();
        }
    }
}
