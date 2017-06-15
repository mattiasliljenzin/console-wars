using aw_console_wars;
using aw_console_wars.Warriors;

namespace aw.AttackStrategies
{
    public interface IAttackStrategy
    {
        AttackResult Execute(Warrior warrior, Warrior target);
    }
}