using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var mtVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon").Single();
            System.Console.WriteLine(mtVernon.ArtistName);
            System.Console.WriteLine(mtVernon.Age);
            //Who is the youngest artist in our collection of artists?
            var youngest = Artists.OrderBy(artist => artist.Age).First();
            System.Console.WriteLine(youngest.ArtistName);
            System.Console.WriteLine(youngest.Age);
            //Display all artists with 'William' somewhere in their real name
            var william = Artists.Where(artist => artist.RealName.Contains("William"));
            foreach(var will in william){
                System.Console.WriteLine(will.ArtistName);
            }
            //Display all groups with names less than 8 characters in length.
            var lessThanEight = Groups.Where(groups => groups.GroupName.Length < 8).ToList();
            foreach (var band in lessThanEight)
            {
                System.Console.WriteLine(band.GroupName);
            }
            //Display the 3 oldest artist from Atlanta
            var threeOldest = Artists.Where(artist => artist.Hometown == "Atlanta").OrderBy(artist => artist.Age).ToList();
            for(int i = 0; i<3; i++){
                System.Console.WriteLine(threeOldest[i].ArtistName);
            }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        
        }

    }
}
