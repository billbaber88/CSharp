using System;

namespace Wizard{
    public class Human{
        public string name;
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }
        

        public Human(string person){
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string person, int s, int i, int d, int h){
            name = person;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;
        }

        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
                System.Console.WriteLine("{0} was attacked by {1}. Health is now {2}", enemy.name, name, enemy.health);
            }
        }
        
    }
}