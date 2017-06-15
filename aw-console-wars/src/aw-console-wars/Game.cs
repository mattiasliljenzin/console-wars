using System;

namespace aw_console_wars
{
    public class Game
    {
        private readonly GameArena _arena;

        public Game(GameArena arena)
        {
            _arena = arena;
        }

        public void Start()
        {
            GameOutput.Report("Game is starting...");
            GameOutput.Report("===================");

            _arena.Begin();
            _arena.Fight();

            while (!_arena.LastManStanding)
            {
                _arena.NextRound();
                _arena.Fight();
            }

            var lastManStanding = _arena.GetLastManStanding();
            var warriorStats = lastManStanding.GetStatistics();

            GameOutput.Report("The arena champion is...");
            GameOutput.Report($"With {warriorStats.DamageDealt} dmg dealt");
            GameOutput.Report($"And {warriorStats.DamageReceived} dmg received");
            GameOutput.Report($"The last man standing is {lastManStanding.GetDescription()} !!!");
        }
    }
}