//Edited HelloWorld program to prompt user for their name and display it out by Nicole Haug

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Enter your name:"); //prompt
            String line = Console.ReadLine(); //Get string from user
            Console.Write("Hello " + line); //Greets person
            Console.ReadLine(); //Pauses to read to user
       
        }
    }
}
