using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using aw;
using aw.AttackStrategies;
using aw_console_wars.Warriors;

namespace aw_console_wars
{
    public static class AttackHandler
    {
        private static IAttackStrategy _currentAttackStrategy = new DefaultAttackStrategy();
        private static readonly IDictionary<Warrior, int> DamageDealers = new Dictionary<Warrior, int>();
        public static bool ReportFinalBattle { get; set; }

        public static void SetAttackStrategy(IAttackStrategy strategy)
        {
            _currentAttackStrategy = strategy;
        }

        public static void Execute(Warrior warrior, Warrior target)
        {
            if (!target.IsAlive()) return;
            if (!warrior.IsAlive()) return;

            var targetHealth = target.CurrentHealth;

            var result = _currentAttackStrategy.Execute(warrior, target);
            UpdateDamageDealers(warrior, result);

            if (ReportFinalBattle)
            {
                GameOutput.Report(
                    $"{warrior.Name} ({warrior.CurrentHealth}hp) attacks " +
                    $"{target.Name} ({targetHealth}hp) with " +
                    $"{result.DamageDealt} damage!");
            }
        }

        private static void UpdateDamageDealers(Warrior warrior, AttackResult result)
        {
            if (!DamageDealers.ContainsKey(warrior))
            {
                DamageDealers[warrior] = 0;
            }
            DamageDealers[warrior] += result.DamageDealt;
        }

        public static IReadOnlyDictionary<Warrior, int> GetDamageDealers()
        {
            return new ReadOnlyDictionary<Warrior, int>(DamageDealers);
        }
    }
}