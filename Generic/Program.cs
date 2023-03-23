using System;
using System.Collections;

namespace Generic_Demo
{
    public class Program

    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the first value");
            double num1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second value");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third value");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double val = FloatMax.MaximumNumber(num1, num2, num3);
            Console.WriteLine("{0}is Greater", val);
        }
    }
}