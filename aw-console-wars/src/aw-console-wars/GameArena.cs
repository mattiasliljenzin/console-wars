using System;
using System.Linq;
using System.Threading;
using aw;
using aw_console_wars.Warriors;

namespace aw_console_wars
{
    public class GameArena
    {
        private Warrior[] _participants = new Warrior[0];
        private Warrior[] _stillStanding = new Warrior[0];

        public bool LastManStanding { get; private set; }

        public GameArena()
        {
            GameOutput.Report("GameSimulator arena created");
        }

        public void AddWarriors(params Warrior[] warriors)
        {
            _participants = warriors;

            foreach (var warrior in warriors)
            {
                GameOutput.Report($"Adding warrior {warrior.Name} to arena!");
            }
        }

        public void Begin()
        {
            GameOutput.Report("Let the game begin!");
            _stillStanding = _participants;
        }

        public void Fight()
        {
            GameOutput.Report("");
            GameOutput.Report("Fight!");

            var stillStandingCount = _stillStanding.Length;
            var shuffle = CreateShuffle(stillStandingCount);

            if (stillStandingCount == 2)
            {
                PrintFinalMatchDetails();
            }

            for (var i = 0; i < stillStandingCount - 1; i+=2)
            {
                var warrior1 = _stillStanding[shuffle[i]];
                var warrior2 = _stillStanding[shuffle[i+1]];
                var battleCage = new GameBattleCage();

                battleCage.Fight(warrior1, warrior2);
            }
            
            _stillStanding = _participants.Where(x => x.IsAlive()).ToArray();

            GameOutput.Report("Fight ended!");
            GameOutput.Report($"{_stillStanding.Length}/{_participants.Length} warriors left!");
            CheckLastManStanding();
        }

        public void NextRound()
        {
            GameOutput.Report("");
            GameOutput.Report("Next round begins!");
            Thread.Sleep(1000);
        }

        private void PrintFinalMatchDetails()
        {
            GameOutput.Report("=== BATTLE FINALE ===");
            GameOutput.Report($"~~~ {_stillStanding[0].Name} VS. {_stillStanding[1].Name} ~~~");
            GameOutput.Report("");
            AttackHandler.ReportFinalBattle = true;
        }

        private void CheckLastManStanding()
        {
            if (_stillStanding.Length == 1)
            {
                LastManStanding = true;
            }
        }

        private static int[] CreateShuffle(int stillStandingCount)
        {
            var random = new Random(DateTime.Now.Millisecond);
            return Enumerable.Range(0, stillStandingCount).OrderBy(c => random.Next(0, stillStandingCount)).ToArray();
        }

        public Warrior GetLastManStanding()
        {
            return _stillStanding.Single();
        }
    }
}
