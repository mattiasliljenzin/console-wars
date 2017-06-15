using aw_console_wars.Warriors;

namespace aw.DamageCalculators
{
    public class DefaultDamageCalculator : IDamageCalculator
    {
        private readonly int DAMAGE_CONSTANT = 1;

        public int Calculate(Warrior warrior)
        {
            return warrior.Strength * DAMAGE_CONSTANT;
        }
    }
}