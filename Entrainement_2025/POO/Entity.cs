using System;
using static POO.Stormp.Stormtroopers;

namespace POO
{

    #region dependencies
    public enum PersoType
    {
        JEDI,
        SITH,
        STORMTROOPER,
        CLONE,
        EWOK,
    }

    public enum Weapon
    {
        None,
        Blaster,
        LightSaber,
        Spears,
    }
    #endregion
    public class Entity
    {
        public string Name;
        protected PersoType type;
        protected int hp;
        public Weapon Weapon;
        protected bool IsKo;
        public POO.Stormp.Stormtroopers Escouade;

        #region Constructor

        public Entity(string name ,PersoType type, int hp, Weapon weapon, POO.Stormp.Stormtroopers escouade)
        {
            this.Name = name;
            this.type = type;
            this.hp = hp;
            this.Weapon = weapon;
            this.Escouade = escouade;
        }

        #endregion

        #region Methods

        public PersoType Type
        {
            get => type;
            set => type = value;
        }

        public int Hp
        {
            get => hp;
            set => hp = value;
        }

        public bool IsKo1
        {
            get => IsKo;
            set => IsKo = value;
        }


        public virtual void WhoAmI()
        {
            Console.WriteLine($"My name is {Name} and I am a {type}  !");
        }


        public virtual void Describe()
        {
            WhoAmI();
            Console.WriteLine($"I have a {Weapon}");
            Console.WriteLine($"I have also {hp} hp ");
            if (type == PersoType.JEDI || type == PersoType.SITH)
            {
                Console.WriteLine($"I am a {type} I don't need Stromtroopers");
            }
            else
            {
                Console.WriteLine($"My escouade is composed of Stromtroopers color {Escouade}");
            }
            
        }

        public Entity GetHurt(int count, Entity perso)
        {
            int i = 0;
            if (count >= perso.hp)
            {
                IsKo = true;
                perso.hp = 0;
                Console.WriteLine("Ono our entity is ko");
                return perso;
            }
            else
            {
                while (i < count)
                {
                    Hp -= 1;
                    i++;
                }
            }

            Console.WriteLine($"{perso.Name} has {hp} hp");
            return perso;
        }

        #endregion
    }

}