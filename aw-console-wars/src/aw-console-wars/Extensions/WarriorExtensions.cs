using System;
using aw_console_wars.Warriors;

namespace aw
{
    public static class WarriorExtensions
    {
        public static string GetDescription(this Warrior warrior)
        {
            return $@"
                    Name: {warrior.Name}
                    Health: {warrior.GetHealthAsPercentage()}
                    Max health: {warrior.Attributes.MaxHealth}
                    Strength: {warrior.Attributes.Strength}
                    Dexterity: {warrior.Attributes.Dexterity}
                    Constitution: {warrior.Attributes.Constitution}";
        }

        public static string GetHealthAsPercentage(this Warrior warrior)
            => $"{(float) warrior.CurrentHealth / warrior.Attributes.MaxHealth:P}";

        public static bool IsAlive(this Warrior warrior) => warrior.CurrentHealth > 0;
    }
}