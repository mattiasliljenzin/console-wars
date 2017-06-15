using aw.DamageCalculators;
using aw_console_wars.Warriors;

namespace aw.AttackStrategies
{
    public class DefaultAttackStrategy : IAttackStrategy
    {
        private readonly IDamageCalculator _damageCalculator = new DefaultDamageCalculator();

        public DefaultAttackStrategy() {}

        public DefaultAttackStrategy(IDamageCalculator damageCalculator)
        {
            _damageCalculator = damageCalculator;
        }

        public void Execute(Warrior warrior, Warrior target)
        {
            var damage = _damageCalculator.Calculate(warrior);
            target.CurrentHealth -= damage;
        }
    }
}