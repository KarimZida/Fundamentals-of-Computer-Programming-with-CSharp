using System;


namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {/*Write a program, which compares correctly two real numbers with
           accuracy at least 0.000001.*/
            Console.WriteLine("Please enter first value...");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second value...");
            float value2 = float.Parse(Console.ReadLine());
            if (Math.Abs(value1 - value2) < 0.000001)
                Console.WriteLine("They are equals");
            else
                Console.WriteLine("They are not equals");
        }
    }
}
