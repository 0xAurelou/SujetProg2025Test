using System;
using POO;

namespace Battle
{

    public class Battle 
    {
        public static void Fight(POO.BadGuys.Sith test, POO.GoodGuys.Jedi test1)
        {
            {
                
                while (!test.IsKo1 && !test1.IsKo1)
                {
                    Console.WriteLine("Tour du Gentil");
                    Random rnd = new Random();
                    int loto = rnd.Next(1, 4);
                    if (loto == 1)
                        test1.Hurt(test1);
                    if (loto == 2)
                        test1.GetHeal(test1);
                    Console.WriteLine("Tour Du mechant");
                    Random rnd1 = new Random();
                    int loto1 = rnd1.Next(1, 3);
                    if (loto1 == 1)
                        test.Hurt(test);
                    Console.WriteLine($"{test.Hp} left {test.Name}");
                    Console.WriteLine($"{test1.Hp} left {test1.Name}");
                }

                if (test.IsKo1)
                {
                    Console.WriteLine($"{test.Name} won the battle");
                }

                if (test1.IsKo1)
                {
                    Console.WriteLine($"{test1.Name} won the battle");
                }

            }
        }
    }
}