using Generic;
using GenericsProblems;
using System;
using System.Collections;

namespace Generic_Demo
{
    public class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second value");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third value");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int val1 = Demo.Max(num1, num2, num3);
            Console.WriteLine("{0}is Greater", val1);


            Console.WriteLine("Please enter the first string");
            string str1 = (Console.ReadLine());
            Console.WriteLine("Please enter the second string");
            string str2 = (Console.ReadLine());
            Console.WriteLine("Please enter the third string");
            string str3 = (Console.ReadLine());
            string val2 = Demo.Max1(str1, str2, str3);
            Console.WriteLine("{0}is Greater", val2);


            Console.WriteLine("Please enter the first double");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second double");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third double");
            double d3 = Convert.ToDouble(Console.ReadLine());
            double val3 = Demo.Max2(d1, d2, d3);
            Console.WriteLine("{0}is Greater", val3);

            GenericDemo.FindMax(num1, num2, num3);
            GenericDemo.FindMax(str1, str2, str3);
            GenericDemo.FindMax(d1, d2, d3);
        }
    }
}