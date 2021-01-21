using System;
using POO;

namespace Battle
{

    public class Battle : GoodGuys.Jedi
    {
        public Battle(string name, PersoType type, int hp, Weapon weapon, POO.POO.Stormp.Stormtroopers escouade, int attack, 
            int heal) : base(name, type, hp, weapon, escouade, attack, heal)
        {
            
        }
    }
}