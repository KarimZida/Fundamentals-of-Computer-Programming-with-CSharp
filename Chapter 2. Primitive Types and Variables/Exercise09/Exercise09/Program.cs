using System;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {/*Declare two variables of type string and assign them a value “The
           "use" of quotations causes difficulties.” (without the outer quotes).
           In one of the variables use quoted string and in the other do not use it*/

            string firstString =" The \"use\" of quotations causes difficulties.";
            string secondString = "The use of quotations causes difficulties.";
            Console.WriteLine("With quotes : {0} \nWithout quotes : {1}", firstString, secondString);

        }
    }
}
