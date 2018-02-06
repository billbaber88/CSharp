using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoShuSquare
{
    class Program
    {
        private static int[,] numbers= { {1,2,3}, {4,5,6}, {7,8,9}};       
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine(counter);
                SwitchCells();
            }
            while(!IsMagicSquare());
            
            DisplayBoard();
            Console.WriteLine($"It took {counter} tries to find this solution.");
        }

        private static void DisplayBoard()
        {
            for(var i=0; i<3; i++)
            {
                for (var c=0; c<3; c++)
                {
                    Console.Write(numbers[i,c] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsMagicSquare()
        {
            var tempSum = numbers[0,0] + numbers[0,1] + numbers[0,2];
            //compare rows
            for (var i=1; i<3; i++)
            {
                if(numbers[i,0] + numbers[i,1] + numbers[i,2] != tempSum)
                {
                    return false;
                }
            }
            //compare columns
            for (var i=0; i<3; i++)
            {
                if(numbers[0,i] + numbers[1,i] + numbers[2,i] != tempSum)
                {
                    return false;
                }
            }

            return numbers[0,0] + numbers[1,1] + numbers[2,2] == tempSum && numbers[0,2] + numbers[1,1] + numbers[2,0] == tempSum;
        }

        private static void SwitchCells()
        {
            int[] num1 = new int[2];
            int[] num2 = new int[2];

            num1[0] = rand.Next(0,3);
            num1[1] = rand.Next(0,3);
            num2[0] = rand.Next(0,3);
            num2[1] = rand.Next(0,3);

            int temp = numbers[num1[0], num1[1]];
            numbers[num1[0], num1[1]] = numbers[num2[0], num2[1]];
            numbers[num2[0], num2[1]] = temp;
        }
            
    }
}
