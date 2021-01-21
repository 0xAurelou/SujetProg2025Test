using System;
using POO;

namespace POO
{
    public class GoodGuys
    {
        public class Jedi: BadGuys.Sith
        {
            protected int Heal;
            public Jedi(string name,PersoType type, int hp, Weapon weapon, POO.Stormp.Stormtroopers escouade,
                int attack,int heal) : base (name,type, hp, weapon, escouade,attack)
            {
                this.Heal = heal;
            }

            public int Heal1
            {
                get => Heal;
                set => Heal = value;
            }

            public override void WhoAmI()
            {
                Console.WriteLine($"My name is {Name} and I am a {type}");
                Console.WriteLine("I am here to save the Republic");
            }


            public void GetHeal(Jedi perso)
            {
                int i = 0;
                if (perso.IsKo)
                {
                    Console.WriteLine("You can't heal a Ko Entity");
                }
                else
                {
                    if (perso.type == PersoType.JEDI)
                    {
                        Hp += 100;
                    }
                    else
                    {
                        Hp += 5;
                    }

                    Hp += Heal;
                    Console.WriteLine($"{perso.Name} has now {hp} hp");
                }
            }
            public void Hurt(Entity entity)
            {
                if (Attack >  entity.Hp )
                {
                    IsKo = true;
                    Console.WriteLine("We killed this entity");
                    Escouade = entity.Escouade;
                    entity.Escouade = POO.Stormp.Stormtroopers.None;
                }
                else
                {
                    entity.Hp -= Attack;
                }
            }
        }
       
    }
}