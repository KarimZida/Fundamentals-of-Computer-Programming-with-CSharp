using System;


namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string castedHelloWorld = (string)helloWorld;

            Console.WriteLine("First world : {0} \nSecond world : {1} \nObject : {2} \nCasted String : {3}", 
                hello , world ,helloWorld,castedHelloWorld);
        }
    }
}
