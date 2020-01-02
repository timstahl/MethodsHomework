using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome();

            string firstName = greeting("What is your first name: ");
            string lastName = greeting("What is your last name: ");

            usersName(firstName, lastName);
            

            Console.ReadLine();
        }

        private static void welcome()
        {
            Console.WriteLine("Welcome to the planet!");
        }

        private static void usersName(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, { firstName } { lastName }");  
        }

        private static string greeting(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

    }
}
