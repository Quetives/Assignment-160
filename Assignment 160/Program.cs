﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_160
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1;
            string num2;
            int int2;
            int Total;
            MathFunction functionOne = new MathFunction();

            Console.WriteLine("Enter a number:");
            int1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:(optional)");
            num2 = Console.ReadLine();
            if (string.IsNullOrEmpty(num2))
            {
                num2 = "0";
                int2 = Convert.ToInt32(num2);
                Total = functionOne.twoInt(int1, int2);

                Console.WriteLine(int1 + " times 5 equals:");
                Console.WriteLine(Total);
            } else
            {
                int2 = Convert.ToInt32(num2);
                Total = functionOne.twoInt(int1, int2);

                Console.WriteLine(int1 + " times 5, plus " + int2 + " equals:");
                Console.WriteLine(Total);
            }          
            Console.ReadLine();
              
        }
    }
}
