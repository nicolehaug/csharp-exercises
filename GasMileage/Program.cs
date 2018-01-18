using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            //m = miles g =gas
            int m, g;
            Console.Write("To find your gas mileage, first enter the number of miles you have driven: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now enter the amount of gas you have used in gallons: ");
            g = Convert.ToInt32(Console.ReadLine());
            //Divide the miles traveled by the amount of gallons it took to refill the tank
            int gasmileage = m / g;

            Console.WriteLine("Your gas mileage is = {0} ", gasmileage);
            Console.ReadKey();
        }
    }
}
