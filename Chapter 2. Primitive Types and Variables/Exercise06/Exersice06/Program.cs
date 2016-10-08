using System;


namespace Exersice06
{
    class Program
    {
        static void Main(string[] args)
        {/*Declare a variable isMale of type bool and assign a value to it depending
           on your gender.*/
            bool isMale;
            Console.WriteLine("Are you male ? yes or no");
            string answer = Console.ReadLine();
            if (answer == "yes")
                isMale = true;
            else
                isMale = false;
            if (isMale)
                Console.WriteLine("You are a male");
            else
                Console.WriteLine("You are not a male");
        }
    }
}
