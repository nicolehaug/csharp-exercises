//Program to find out the area of a rectangle with prompt for dimensions from user. By Nicole Haug
using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, h;
            Console.Write("To find the area of your rectangle, first enter the length of the Rectangle: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now enter the height of the Rectangle: ");
            h = Convert.ToInt32(Console.ReadLine());
            int area = l * h;
           
            Console.WriteLine("Area of the Rectangle is = {0} ", area);
            Console.ReadKey();
        }
    }
}
