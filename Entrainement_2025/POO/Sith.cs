using System;
using POO;

namespace POO
{
    public class BadGuys
    {
        public class Sith : Entity
        {
            # region Constructor

            protected int Attack;
            

            public Sith(string name,PersoType type, int hp, Weapon weapon, POO.Stormp.Stormtroopers escouade,
                int attack) : base (name,type, hp, weapon, escouade)
            {
                this.Attack = attack;
            }
            
            #endregion
        
            #region Methods

            public int Attack1
            {
                get => Attack;
                set => Attack = value;
            }
            public override void WhoAmI()
            {
                Console.WriteLine($"My name is {Name} and I am a {type}");
                Console.WriteLine($"I am here to destroy the rebel alliance ");
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

            #endregion
        }
    }
}