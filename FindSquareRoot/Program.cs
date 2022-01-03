using System;
using static System.Console;

namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, sqrt;
            try
            {
                Write("Enter number: ");
                if (!double.TryParse(ReadLine(), out number))
                    WriteLine("Entered number is not a double: ");
                if (number < 0)
                    throw (new ApplicationException("Number can't be negative: "));
                sqrt = Math.Sqrt(number);
            }
            catch (ApplicationException e)
            {
                WriteLine("Error: {0}", e.Message);
                sqrt = 0;
            }
            WriteLine("Square root is {0}", sqrt);
        }
    }
}
