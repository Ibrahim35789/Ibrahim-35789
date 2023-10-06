//Hello sir ye variable code hai

using System;

namespace Methods
{
    internal class Program
    {
        private static int Result;

        public static void Add(int A, int B)
        {
            Result = A + B;
        }

        public static void Subtract(int A, int B)
        {
            Result = A - B;
        }

        public static void Multiply(int A, int B)
        {
            Result = A * B;
        }

        public static void Divide(int A, int B)
        {
            Result = A / B;
        }

        public static void Pass(int A)
        {
            if (A > 30)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void AGrade(int A)
        {
            if (A >= 90)
            {
                Console.WriteLine("A+ Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        public static void BGrade(int A)
        {
            if (A >= 70)
            {
                Console.WriteLine("B Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        public static void CGrade(int A)
        {
            if (A >= 60)
            {
                Console.WriteLine("C Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void DGrade(int A)
        {
            if (A >= 50)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void FGrade(int A)
            {
                if (A <= 49)
                {
                    Console.WriteLine("FGrade");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }

        public static void Main(string[] args)
        {
            Pass(99);
            AGrade(99);
            Pass(75);
            BGrade(75);
            Pass(69);
            CGrade(69);
            Pass(59);
            DGrade(59);
            FGrade(31);
            FGrade(31);
        }
    }
}