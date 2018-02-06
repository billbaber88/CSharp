using System;

namespace Wizard
{
    public class Samurai : Human 
    {
        public Samurai(string person) : base(person)
        {
            health = 200;
        }

        public void deathblow(Human enemy){
            if(enemy.health < 50){
                enemy.health = 0;
                System.Console.WriteLine("{0} has been killed. Long live {0}'s memory!", enemy.name);
            } else {
                System.Console.WriteLine("Swing and a miss");
            }
        }

        public void meditate(){
            this.health = 200;
        }

    }
}