using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop Solution");

            string text;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    text = "fizzbuzz";
                }
                else if (i % 5 == 0)
                {
                    text = "buzz";
                }
                else if (i % 3 == 0)
                {
                    text = "fizz";
                }
                else
                {
                    text = i.ToString();
                }

                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.WriteLine("Recursion solution");
            RecursiveSolution(100);
        }

        

        private static void RecursiveSolution(int n)
        {
            string text;
            if(n <1)
            {
                return;
            }
             if (n % 3 == 0 && n % 5 == 0)
                {
                    text = "fizzbuzz";
                }
                else if (n % 5 == 0)
                {
                    text = "buzz";
                }
                else if (n % 3 == 0)
                {
                    text = "fizz";
                }
                else
                {
                    text = n.ToString();
                }

                Console.WriteLine(text);
                RecursiveSolution(n-1);
            }
        }
    }
