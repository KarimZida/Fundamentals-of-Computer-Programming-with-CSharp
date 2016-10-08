using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {/*Declare two variables of type string with values "Hello" and "World".
           Declare a variable of type object. Assign the value obtained of
           concatenation of the two string variables (add space if necessary) to this
           variable. Print the variable of type object*/
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            Console.WriteLine(helloWorld);
        }
    }
}
