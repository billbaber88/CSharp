using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    { 
        public static string SayHello(string name = "buddy"){
            return $"Hey {name}";
        }
        static void Main(string[] args)
        {
            List<object> names = new List<object>();
            names.Add(7);
            names.Add(28);
            names.Add(-1);
            names.Add(true);
            names.Add("chair");
            int sum = 0;

            for(int i = 0; i<names.Count; i++){
                System.Console.WriteLine(names[i]);
            }

            foreach (var name in names){
                if(name is int){
                    sum += (int)name;
                }
            }
            System.Console.WriteLine("sum is " + sum);

            System.Console.WriteLine(SayHello("Mark"));
        }
    }
}
