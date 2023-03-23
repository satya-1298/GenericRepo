using System;
using System.Collections;

namespace Generic_Demo
{
    public class Program

    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the first value");
            string str1 = (Console.ReadLine());
            Console.WriteLine("Please enter the second value");
            string str2 = (Console.ReadLine());
            Console.WriteLine("Please enter the third value");
            string str3 = (Console.ReadLine());
            string val = StringMax.MaximumNumber(str1,str2,str3);
            Console.WriteLine("{0}is Greater", val);
        }
    }
}