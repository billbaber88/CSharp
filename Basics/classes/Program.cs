using System;

namespace Wizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Bob = new Human("Bob");
            Wizard Bill = new Wizard("Bill");
            Samurai Larry = new Samurai("Larry");
            Ninja Bubba = new Ninja("Bubba");
            Bob.attack(Bill);
            Bill.fireball(Bob);
            Bill.fireball(Bob);
            Bill.heal();
            Larry.deathblow(Bob);
            Bill.fireball(Larry);
            Larry.meditate();
            Bubba.steal(Bill);
            Bubba.getAway();

        }
    }
}
