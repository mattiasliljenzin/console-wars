using System;

namespace aw_console_wars.Warriors
{
    public abstract class Warrior
    {
        public void Attack(Warrior warrior)
        {
            AttackHandler.Execute(this, warrior);
        }

        public string GetDescription()
        {
            return $@"
                    Name: \t{Name}{Environment.NewLine}
                    Health: \t{GetHealthAsPercentage()}{Environment.NewLine}
                    Max health: \t{Attributes.MaxHealth}{Environment.NewLine}
                    Strength: \t{Attributes.Strength}{Environment.NewLine}
                    Dexterity: \t{Attributes.Dexterity}{Environment.NewLine}
                    Constitution: {Attributes.Constitution}{Environment.NewLine}";
        }

        public string GetHealthAsPercentage() => $"{CurrentHealth / Attributes.MaxHealth:P}%";

        public abstract string Name { get; }
        public abstract int CurrentHealth { get; set; }

        public bool IsAlive => CurrentHealth > 0;

        public virtual WarriorAttributes Attributes { get; } = new WarriorAttributes();

        public DamageReport GetStatistics()
        {
            return new DamageReport(0, Attributes.MaxHealth - CurrentHealth);
        }
    }
}