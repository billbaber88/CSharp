using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void findMax(int[] arr){
            int max = arr[0];
            for(int j=1; j<arr.Length; j++){
                if (arr[j]>max){
                    max = arr[j];
                }
            }
            System.Console.WriteLine(max);
        }


        static void getAverage(int[] arr){
            int sum = 0;
            for(int i = 0; i<arr.Length; i++){
                sum += arr[i];
            }
            System.Console.WriteLine(sum/arr.Length);
        }
        
        static void odds(){
            List<int> oddList = new List<int>();
            for(int j = 1; j<256; j+=2){
                oddList.Add(j);
            }
            System.Console.WriteLine(oddList.ToArray());
        }

        static void greaterThanY(int[] arr, int num){
            int count = 0;
            for(int i = 0; i<arr.Length; i++){
                if(arr[i]>num){
                    count++;
                }
            }
            System.Console.WriteLine(count);
        }

        static void squareValues(int[] arr){
            for(int i = 0; i<arr.Length; i++){
                arr[i] = arr[i]*arr[i];
            }
            
        }

        static void eliminateNegatives(int[] arr){
            for(int i = 0; i<arr.Length; i++){
                if(arr[i] < 0){
                    arr[i]=0;
                }
            }
        }

        static void minMaxAvg(int[] arr){
            int min = arr[0];
            int max = arr[0];
            double sum = 0;
            for(int i = 0; i<arr.Length; i++){
                sum+=arr[i];
                if(arr[i]>max){
                    max=arr[i];
                }
                if(arr[i]<min){
                    min=arr[i];
                }
            }
            System.Console.WriteLine("The minimum number is {0}", min);
            System.Console.WriteLine("The maximum number is {0}", max);
            System.Console.WriteLine("The average of all numbers is {0}", sum/arr.Length);
        }

        static void shiftingNumbers(int[] arr){
            for(int i=0; i<arr.Length-1; i++){
                arr[i]=arr[i+1];
            }
            arr[arr.Length-1] = 0;
        }
        
        static void numberToString(object[] arr){
            for(int i=0; i<arr.Length; i++){
                if(arr[i] is int){
                    if((int)arr[i]<3){
                        arr[i]="dojo";
                    }
                }
            }
        }
        

            
        static void Main(string[] args)
        {
            print 1-255
            for(int i = 1; i<256; i++){
                System.Console.WriteLine(i);
            }

            // print odds 1-255
            for(int j = 1; j<256; j=j+2){
                System.Console.WriteLine(j);
            }

            // 1-255 with total at each number
            int sum=0;
            for(int k = 1; k<256; k++){
                sum+=k;
                System.Console.WriteLine("The current numer is {0} and the current total is {1}", k, sum);

            }

            // iterate through array
            string[] words = new string[] {"I'm", "a", "little", "tea", "pot"};
            for (int i = 0; i<words.Length; i++){
                System.Console.WriteLine(words[i]);
            }

            //find max
            int[] maxFirst= new int[] {1,2, -3, 8, 9, -20, 4,5,7,8,22,3,45,22,11,2,678,3,2};
            object[] second= new object[] {1,2, -3, "cats", 9, -20, true,5,7,8, "frodo" ,3,45,22,11,2,678,3,2};
            // findMax(maxFirst);

            //get average
            getAverage(maxFirst);

            
            greaterThanY(maxFirst, 4);

            squareValues(maxFirst);

            eliminateNegatives(maxFirst);

            minMaxAvg(maxFirst);

            shiftingNumbers(maxFirst);

            numberToString(second);
    }
    }
}
