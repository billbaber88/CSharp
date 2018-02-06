using System;

namespace Wizard {
    public class Wizard : Human 
    {
        
        public Wizard(string person) : base(person){
            health = 50;
            intelligence = 25;
        }

        public void fireball(Human enemy){
            Random rand = new Random();
            int hit = rand.Next(20,51);
            enemy.health -= hit;
            System.Console.WriteLine("{0} was hit with a fireball by {1}. Health has decreased by {2} to {3}", enemy.name, name, hit, enemy.health);
        }

        public void heal(){
            this.health += 10*intelligence;
            System.Console.WriteLine("{0}'s Health has been increased to {1}", name, this.health);
        }
    }
}