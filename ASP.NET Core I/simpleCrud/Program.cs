using System;
using DbConnection;


namespace simpleCrud
{
    class Program
    {

        public static void read()
        {
            var allUsers = DbConnector.Query("SELECT * FROM users");

            foreach(var user in allUsers)
            {
                System.Console.WriteLine(user["FirstName"] + " " + user["LastName"] + " - " + user["FavoriteNumber"]);
            }
        }

        public static void create()
        {
            System.Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            string fn = '"' + firstName + '"'; 
            System.Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            string ln = '"' + lastName + '"';
            System.Console.WriteLine("Enter Favorite Number");
            string favNum = Console.ReadLine();
            string fvn = '"' + favNum + '"';
            string insertQuery = $"INSERT into users(FirstName, LastName, FavoriteNumber) VALUES ({fn}, {ln}, {fvn})";
            DbConnector.Execute(insertQuery);
            read();
        }

        
    
        static void Main(string[] args)
        {
            read();
        }
    
    }
}

