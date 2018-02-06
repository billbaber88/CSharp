using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Loop Solution");
         {
             var num1 = 0;
             var num2 = 1;
             for(int i =0; i<=15; i++)
             {
                 var next = num1+num2;
                 num1 = num2;
                 num2 = next;

                 Console.Write(next);
             }

             Console.WriteLine("");
             Console.WriteLine("recursion loop");
             for(int i = 0; i<=15; i++)
             {
                 Console.WriteLine(RecursiveSolution(i));
             }
         }
        }

         private static int RecursiveSolution(int n)
         {
             if(n<1)
             {
                 return 1;
             }

             return RecursiveSolution(n-2) + RecursiveSolution(n-1);
             
         }


        }
    }

