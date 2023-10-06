// My Calculator in C# (Ibrahim 35789)


using System;

namespace Calculator
{
    internal class Program
    {
        
           public static double Result;
           public static void Add(double A, double B)
    {
            Result = A + B;
        }

           public static void Subtract(double A, double B)
    {
            Result = A - B;
        }

           public static void Multiply(double A, double B)
    {
            Result = A * B;
        }

           public static void Divide(double A, double B)
    {
            Result = A / B;
        }

           public static void Main(string[] args)
    {
            Add(2.12458, 30);
            Console.WriteLine("Answer is: " + Result);

            Multiply(6, 9.5);
            Console.WriteLine("Answer is: " + Result);

            Subtract(150, 100);
            Console.WriteLine("Answer is: " + Result);

            Divide(90,5.9);
            Console.WriteLine("Answer is: " + Result);
            

        }
    }
}

