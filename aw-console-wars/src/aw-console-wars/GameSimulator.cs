using System;
using System.Linq;
using aw;
using aw_console_wars.Warriors;

namespace aw_console_wars
{
    public class GameSimulator
    {
        private readonly GameArena _arena;

        public GameSimulator(GameArena arena)
        {
            _arena = arena;
        }

        public void Start()
        {
            GameOutput.Report("GameSimulator is starting...");
            GameOutput.Report("============================");

            _arena.Begin();
            _arena.Fight();

            while (!_arena.LastManStanding)
            {
                _arena.NextRound();
                _arena.Fight();
            }
            
            PrintGameDetails();
        }

        private void PrintGameDetails()
        {
            var lastManStanding = _arena.GetLastManStanding();

            GameOutput.Report($"The last man standing is {lastManStanding.Name} !!!");
            GameOutput.Report($"{lastManStanding.GetDescription()}");
            GameOutput.Report("");
            GameOutput.Report("Top damage dealers");
            GameOutput.Report("==================");

            foreach (var damageDealer in AttackHandler.GetDamageDealers().OrderByDescending(x => x.Value))
            {
                GameOutput.Report($"{damageDealer.Value} damage dealt from {damageDealer.Key.Name}! ");
            }
        }
    }
}