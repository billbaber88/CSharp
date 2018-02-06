using System;
using System.Collections.Generic;



namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,3,4,5,6,7,8,9,10};
            string[] names = new string[5] {"Sally", "Paul", "Bob", "AntiBob", "toby"};
            bool[] ya = new bool[10] {true, false, true, false, true, false, true, false, true, false};

            int [,] table = new int[10,10];
            for (var i = 1; i<11; i++){
                for(int j = 1; j<11; j++){
                    table[i-1,j-1] = i*j;
                }
            }

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocoate");
            flavors.Add("Bacon");
            flavors.Add("Tacos");
            flavors.Add("Beans");

            Dictionary<string, string> animals = new Dictionary<string, string>();

            foreach(string name in names){
                animals.Add(name, null);
            }
            Random rand = new Random();
            foreach (string name in names){
                animals[name] = flavors[rand.Next(0, flavors.Count)];
            }
            foreach(var entry in animals){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
