using aw_console_wars.Warriors;

namespace aw.AttackStrategies
{
    public interface IAttackStrategy
    {
        void Execute(Warrior warrior, ILivingThing livingThing);
    }
}