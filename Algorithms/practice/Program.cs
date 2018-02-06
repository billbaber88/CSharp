using System;

namespace practice
{
    class Program
    {
        static int count = 1;
        static void Main(string[] args)
        {
            var discs = 0;
            Console.WriteLine("How many discs will we be using today?");
            discs = Convert.ToInt32(Console.ReadLine());

            Tower(discs, 1, 3, 2);
        }

            
            static void Tower(int n, int startingPeg, int destinationPeg, int sparePeg)
            {
                if(n == 1)
                {
                    Console.WriteLine("Move#" + count + ": " + startingPeg + " -> " + destinationPeg);
                    count++;
                }
                else
                {
                    Tower(n-1, startingPeg, sparePeg, destinationPeg);
                    Console.WriteLine("Move#" + count + ": " + startingPeg + " -> " + destinationPeg);
                    count++;
                    Tower(n-1, sparePeg, destinationPeg, startingPeg );
                }
            }
        }
    }

