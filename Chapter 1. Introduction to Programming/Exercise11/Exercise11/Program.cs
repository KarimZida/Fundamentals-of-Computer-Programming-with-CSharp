using System;


namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads your age from the console and prints your
              age after 10 years.*/
            Console.WriteLine("What is your age?");
            int myAge = int.Parse(Console.ReadLine());
            myAge += 10;
            Console.WriteLine("Your age after ten years : {0}",myAge);
        }
    }
}
