using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aw_console_wars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var warriorGenerator = new WarriorGenerator();
            var warriors = warriorGenerator.GenerateWarriors(10);

            var arena = new GameArena();
            arena.AddWarriors(warriors);

            var game = new Game(arena);
            game.Start();
        }
    }
}
