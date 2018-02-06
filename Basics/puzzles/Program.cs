using System;

namespace puzzles
{
    class Program
    {
        // Create a random array of integers that's 10 numbers long, then find the Min, Max, and Average of the array
            static void randomArray(){
            int[] arr = new int[10];
            double sum = 0;
            Random rand = new Random();
            for(int i = 0; i<10; i++){
                arr[i]=rand.Next(5,26);
                sum+=arr[i];
                System.Console.WriteLine("Number #{0} is {1}", (i+1), arr[i]);
                System.Console.WriteLine("The running total is {0}", sum);
            }
            int max=arr[0];
            int min=arr[1];
            foreach(int num in arr){
                if(num>max){
                    max = num;
                }
                if(num<min){
                    min=num;
                }
            }
            System.Console.WriteLine("The smallest number generated was {0}", min);
            System.Console.WriteLine("The largest number generated was {0}", max);
            System.Console.WriteLine("The average of all the numbers that were generated is {0}", sum/10);
        }

        // Coin Toss- randomize a coin toss and display the results
        static string coinToss(){
            System.Console.WriteLine("Flipping the coin");
            Random rand = new Random();
            int toss = rand.Next(0,2);
            if(toss==0){
                System.Console.WriteLine("Heads!");
                return "heads";
            } else {
                System.Console.WriteLine("Tails");
                return "tails";
            }
        }

        // Shuffle the array and print the values in the new order. Return an array that only includes strings longer than 5 characters
        static void shuffleAround(string[] arr){
            int count = 0;
            for(int i = 0; i<arr.Length; i++){
                if(arr[i].Length>=5){
                    count++;
                }
            }
            string[] newArr = new string[count];
            System.Console.WriteLine("New Array length is {0}", newArr.Length);
            Random rand = new Random();
            for(int j = 0; j<arr.Length; j++){
                if(arr[j].Length>=5){
                    int newIndex = rand.Next(0,count);
                    System.Console.WriteLine("new index is {0}", newIndex);
                    if(newArr[newIndex] == null){
                        System.Console.WriteLine("inserting {0} into new array index {1}", arr[j], newIndex);
                        newArr[newIndex] = arr[j];
                    }else {
                        for(int k = 0; k<newArr.Length; k++){
                            System.Console.WriteLine("k has looped through and is now at {0}", k);
                            if(newArr[k] == null){
                                System.Console.WriteLine("Found a null value in index {0}", k);
                                newArr[k] = arr[j];
                                System.Console.WriteLine(newArr[k]);
                                break;
                            } else {
                                System.Console.WriteLine("Seat taken. Looping from {0} to {1}", k, (k+1));
                            }
                        }
                    }

                } else {
                    continue;
                }
            }
            for(int h = 0; h<newArr.Length; h++){
                System.Console.WriteLine("Index {0} value: {1}", h, newArr[h]);
            }
        }



        static void Main(string[] args)
        {
            // randomArray();
            // coinToss();

            string[] Names = new string[] {"Elvis", "Mike", "Yoyo Ma", "Bob", "Bill", "Bert", "Ernie", "Tiger", "Elephant", "Simba", "Rob", "William", "Fernando", "Saltine Crackers", "Yogi Bear", "Elf", "Tommy LaRue"};
            shuffleAround(Names);

        }
    }
}
