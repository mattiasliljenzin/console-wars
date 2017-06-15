using System;
using aw_console_wars.Warriors;

namespace aw_console_wars
{
    public class GameBattleCage
    {
        public void Fight(Warrior warrior1, Warrior warrior2)
        {
            var coinToss = new Random(DateTime.Now.Millisecond).Next(0, 1024);

            if (coinToss % 2 == 0)
            {
                warrior1.Attack(warrior2);
                warrior2.Attack(warrior1);
            }
            else
            {
                warrior2.Attack(warrior1);
                warrior1.Attack(warrior2);
            }
        }
    }
}