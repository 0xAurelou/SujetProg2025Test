using System;
using POO;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                GoodGuys.Jedi test3 =  new GoodGuys.Jedi("Ewok", PersoType.EWOK, 200, Weapon.Spears, 
                    POO.Stormp.Stormtroopers.Blue, 70, 10);

                BadGuys.Sith test2 = new BadGuys.Sith("StormTrooper", PersoType.STORMTROOPER, 100, Weapon.Blaster,
                    POO.Stormp.Stormtroopers.Green, 40);
                
                Battle.Battle.Fight(test2,test3);

            }
        }
    }
}