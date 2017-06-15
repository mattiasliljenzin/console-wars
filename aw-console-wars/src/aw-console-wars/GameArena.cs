using System.Collections.Generic;
using aw_console_wars.Warriors;

namespace aw_console_wars
{
    public class GameArena
    {
        private readonly LinkedList<Warrior> _warriors = new LinkedList<Warrior>();
        public bool LastManStanding { get; set; }

        public GameArena()
        {
            GameOutput.Report("Game arena created");
        }

        public void AddWarriors(params Warrior[] warriors)
        {
            foreach (var warrior in warriors)
            {
                GameOutput.Report($"Adding warrior {warrior.GetDescription()} to arena!");

                _warriors.AddLast(warrior);
            }
        }

        public void Begin()
        {
            GameOutput.Report("Let the game begin!");
            throw new System.NotImplementedException();
        }

        public void Fight()
        {
            GameOutput.Report("Fight!");

            throw new System.NotImplementedException();
        }

        public void NextRound()
        {
            GameOutput.Report("");
            GameOutput.Report("Next round!");

            throw new System.NotImplementedException();
        }

        public Warrior GetLastManStanding()
        {
            throw new System.NotImplementedException();
        }
    }
}
