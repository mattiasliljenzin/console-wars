using System;

namespace aw_console_wars.Warriors
{
    public abstract class Warrior : ILivingThing
    {
        public void Attack(ILivingThing livingThing)
        {
            AttackHandler.Execute(this, livingThing);
        }

        public string GetDescription()
        {
            return $@"
                    Name: \t{Name}{Environment.NewLine}
                    Health: \t{GetHealthAsPercentage()}{Environment.NewLine}
                    Max health: \t{MaxHealth}{Environment.NewLine}
                    Strength: \t{Strength}{Environment.NewLine}
                    Dexterity: \t{Dexterity}{Environment.NewLine}
                    Constitution: {Constitution}{Environment.NewLine}";
        }

        public string GetHealthAsPercentage() => $"{CurrentHealth / MaxHealth:P}%";

        public abstract string Name { get; }
        public abstract int MaxHealth { get; }
        public abstract int Strength { get; }
        public abstract int Dexterity { get; }
        public abstract int Constitution { get; }
        public abstract int CurrentHealth { get; set; }

        public bool IsAlive => CurrentHealth > 0;

        public DamageReport GetStatistics()
        {
            return new DamageReport(0, MaxHealth - CurrentHealth);
        }
    }
}