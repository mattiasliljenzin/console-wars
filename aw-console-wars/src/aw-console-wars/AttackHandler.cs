using aw.AttackStrategies;
using aw_console_wars.Warriors;

namespace aw_console_wars
{
    public static class AttackHandler
    {
        private static IAttackStrategy _currentAttackStrategy = new DefaultAttackStrategy();

        public static void SetAttackStrategy(IAttackStrategy strategy)
        {
            _currentAttackStrategy = strategy;
        }

        public static void Execute(Warrior warrior, ILivingThing livingThing)
        {
            _currentAttackStrategy.Execute(warrior, livingThing);
        }
    }
}