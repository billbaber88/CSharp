using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth value as an integer: ");
            var n = Convert.ToInt32(Console.ReadLine());

            //loop calculation
            Console.WriteLine($"Loop calculation: Factorial of {n} is {CalculateLoop(n)}");

            //recursion
            Console.WriteLine($"Recursion calculation: Factorial of {n} is {CalculateRecursion(n)}");
        }

        private static int CalculateLoop(int n)
        {
            var factorial = n;
            for (int i = 2; i<n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private static int CalculateRecursion(int n)
        {
            if(n == 1)
                return 1;
            return n*CalculateRecursion(n-1);
        }
    }
}
