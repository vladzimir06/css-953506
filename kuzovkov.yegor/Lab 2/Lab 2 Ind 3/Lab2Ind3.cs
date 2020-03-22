using System;
using System.Numerics;

namespace Lab2Ind3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a, b;
            bool successA, successB;
            bool flagA, flagB;
            int amount = 0;

            while (ulong.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error. You've entered an invalid. Please, enter a value above zero. ");

            }

            do
            {
                Console.Write("Enter the first number : ");
                successA = ulong.TryParse(Console.ReadLine(), out a);
                if (successA)
                {
                    flagA = true;
                    Console.WriteLine("Okay!");
                }
                else
                {
                    flagA = false;
                    Console.WriteLine("Error. You've entered an invalid. Please, enter a value above zero. ");
                }
            } while (flagA == false);

            do
            {
                Console.Write("Enter the second number : ");
                successB = UInt64.TryParse(Console.ReadLine(), out b);
                if (successB && a != b)
                {
                    flagB = true;
                    Console.WriteLine("Okay!\n");
                }
                else if (a == b)
                {
                    flagB = false;
                    Console.WriteLine("Error. The values must be different.\n");
                }
                else
                {
                    flagB = false;
                    Console.WriteLine("Error. You've entered an invalid. Please, enter a value above zero.\n");
                }
            } while (flagB == false);


            BigInteger number = new BigInteger(a);


            if (a < b)
            {
                for (ulong i = a + 1; i < b; i++)
                {
                    number *= i;
                }
            }

            else if (a > b)
            { 
                for (ulong i = b + 1; i < a; i++)
                {
                    number *= i;
                }
            }


            while (number > 0)
            {
                number /= 2;
                amount++;
            }

            Console.WriteLine($"The answer is: {amount}");

        }
    }
}
