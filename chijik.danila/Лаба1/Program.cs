using System;
using static System.Math;

namespace ConsoleApp1
{
    class Program
    {
        public const double PI = 3.14159265358979;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nWrite data\nExample:Ax^3+Bx^2+Cx+D=0\n");
            bool exit = false;
            do
            {
                Console.Write("A=");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("B=");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.Write("C=");
                int C = Convert.ToInt32(Console.ReadLine());
                Console.Write("D=");
                int D = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A={0} B={1} C={2} D={3}", A, B, C, D);
                Console.WriteLine("Is data correct?(Yes or No)");
                string check = Console.ReadLine();
                if (check == "Yes")
                {
                    double Q = (Pow(B / A, 2) - (3 * (C / A))) / 9;
                    double R = ((2 * Pow((B / A), 3)) - (9 * (B / A) * (C / A)) + (27 * (D / A))) / 54;
                    double S = Pow(Q, 3) - Pow(R, 2);
                    int sgnR = 0;
                    if (R < 0) { sgnR = -1; }
                    else if (R > 0) { sgnR = 1; };
                    if (S > 0)
                    {
                        double t = Acos(R / Sqrt(Pow(Q, 3))) / 3;
                        double x1 = -2 * Sqrt(Q) * Cos(t) - ((B / A) / 3);
                        double x2 = -2 * Sqrt(Q) * Cos(t + ((2 * PI) / 3)) - ((B / A) / 3);
                        double x3 = -2 * Sqrt(Q) * Cos(t - ((2 * PI) / 3)) - ((B / A) / 3);
                        Console.Clear();
                        Console.WriteLine("\n\nx1 = {0}\nx2 = {1}\nx3 = {2}", x1, x2, x3);
                    }
                    if (S < 0)
                    {
                        if (Q > 0)
                        {

                            double t = Log(Abs(R) / Sqrt(Pow(Q, 3))+Sqrt(Pow(Abs(R) / Sqrt(Pow(Q, 3)),2)+1)) / 3;
                            double x1 = (-2 * sgnR * Sqrt(Q) * Cosh(t)) - ((B / A) / 3);
                            double x2 = (sgnR * Sqrt(Q) * Cosh(t)) - ((B / A) / 3);
                            double complex = Sqrt(3) * Sqrt(Q) * Sinh(t);
                            Console.Clear();
                            Console.WriteLine("\n\nValid x1 = {0}\nComplex x2 = {1} + {2}*i\nComplex x3 = {3} - {4}*i\n", x1, x2, complex, x2, complex);
                        }
                        if (Q < 0)
                        {
                            double tt = Abs(R) / Sqrt(Pow(Abs(Q), 3));
                            double t = Log(tt + Sqrt(Pow(tt,2) - 1)) / 3;
                            double x1 = (-2 * sgnR * Sqrt(Abs(Q)) * Sinh(t)) - ((B / A) / 3);
                            double x2 = (sgnR * Sqrt(Abs(Q)) * Sinh(t)) - ((B / A) / 3);
                            double complex = Sqrt(3) * Sqrt(Abs(Q)) * Cosh(t);
                            Console.Clear();
                            Console.WriteLine("\n\nValid x1 = {0}\nComplex x2 = {1} + {2}*i\nComplex x3 = {3} - {4}*i\n", x1, x2, complex, x2, complex);
                        }
                        if (Q == 0)
                        {
                            double x1 = -Pow((D / A) - (Pow(B / A, 3) / 27) - ((B / A) / 3), 1 / 3);
                            double x2 = -((B / A) + x1) / 2;
                            double complex = Sqrt(Abs((((B / A) - 3 * x1) * ((B / A) + x1)) - 4 * (C / A))) / 2;
                            Console.Clear();
                            Console.WriteLine("\n\nValid x1 = {0}\nComplex x2 = {1} + {2}*i\nComplex x3 = {3} - {4}*i\n", x1, x2, complex, x2, complex);
                        }

                    }
                    if (S == 0)
                    {
                        double x1 = (-2 * Pow(R, 1 / 3)) - ((B / A) / 3);
                        double x2 = (Pow(R, 1 / 3)) - ((B / A) / 3);
                        Console.Clear();
                        Console.WriteLine("\n\nx1 = {0}\nx2 = {1}", x1, x2);
                    };
                    exit = true;
                    Console.ReadKey();
                }
                else if (check != "No")
                {
                    Console.WriteLine("ERROR");
                };


            }
            while (exit == false);
        }
    }
}