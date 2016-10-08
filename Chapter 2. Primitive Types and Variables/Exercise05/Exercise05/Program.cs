using System;


namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {/*Declare a variable of type char and assign it as a value the character,
           which has Unicode code, 72 (use the Windows calculator in order to find
           hexadecimal representation of 72).*/
            char myChar = '\u0048';
            Console.WriteLine(myChar);
        }
    }
}
