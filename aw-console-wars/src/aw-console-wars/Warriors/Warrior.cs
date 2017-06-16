
namespace aw_console_wars.Warriors
{
    public abstract class Warrior
    {
        protected Warrior()
        {
            CurrentHealth = Attributes.MaxHealth;
        }

        public void Attack(Warrior warrior)
        {
            AttackHandler.Execute(this, warrior);
        }

        public abstract string Name { get; set; }
        public int CurrentHealth { get; set; }

        public IWarriorAttributes Attributes { get; set; } = new DefaultWarriorAttributes();
    }
}