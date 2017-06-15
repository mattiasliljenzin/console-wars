using System;

namespace aw_console_wars.Warriors
{
    public abstract class Warrior
    {
        public void Attack(Warrior warrior)
        {
            AttackHandler.Execute(this, warrior);
        }

        public static string GetDescription(Warrior warrior)
        {
            return $@"
                    Name: \t{warrior.Name}{Environment.NewLine}
                    Health: \t{warrior.GetHealthAsPercentage()}{Environment.NewLine}
                    Max health: \t{warrior.MaxHealth}{Environment.NewLine}
                    Strength: \t{warrior.Attributes.Strength}{Environment.NewLine}
                    Dexterity: \t{warrior.Attributes.Dexterity}{Environment.NewLine}
                    Constitution: {warrior.Attributes.Constitution}{Environment.NewLine}";
        }

        public string GetHealthAsPercentage() => $"{CurrentHealth / MaxHealth:P}%";

        public abstract string Name { get; }
        public abstract int MaxHealth { get; }
        public abstract int CurrentHealth { get; set; }

        public bool IsAlive => CurrentHealth > 0;

        public virtual WarriorAttributes Attributes { get; } = new WarriorAttributes();

        public DamageReport GetStatistics()
        {
            return new DamageReport(0, MaxHealth - CurrentHealth);
        }
    }
}