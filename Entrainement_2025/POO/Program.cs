using System;
using POO;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BadGuys.Sith Palpatine = new BadGuys.Sith("Palpatine", PersoType.SITH, 1000, Weapon.LightSaber,
                POO.Stormp.Stormtroopers.None, 500);
            Palpatine.WhoAmI();
            Palpatine.Describe();
            Palpatine.GetHurt(999,Palpatine);
            Console.WriteLine(Palpatine.Hp);
        }
    }
}