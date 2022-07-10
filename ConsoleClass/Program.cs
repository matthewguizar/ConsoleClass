using System;
using System.Collections.Generic;

namespace ConsoleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            /*asking user to input and then printing back their input
             * Asking user to enter string and getting input on same line.
            */
            Console.Write("Enter a string and press enter: ");


            //readline takes Sring or integer input
            string input = Console.ReadLine();


            //prints input on the next line (adding line break)

            //format makes it so that {0} is replaced with the value after the comma (instead of concatenating)
            Console.WriteLine("you entered {0}:",input);


            /*
             * asking user to input value on same line and giving them the ASCII value
             */
            Console.Write("Enter a string and press enter ");

            //using Console.Read() to get single input and method returns ASCII value of input (INTEGER VALUE) if there are none returns -1
            int asciiValue = Console.Read();

            Console.Write("Ascii value is {0}", asciiValue);

            Console.ReadKey();
        }
    }
}
