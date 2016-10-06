using System;


namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name ?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name ?");
            string secondName = Console.ReadLine();
            Console.WriteLine("Your first name is {0} and your last name is {1}.", firstName, secondName);
        }
    }
}
