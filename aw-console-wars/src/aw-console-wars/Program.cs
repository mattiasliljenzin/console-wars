using System.Linq;

namespace aw_console_wars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var warriorGenerator = new WarriorGenerator();
            var warriors = warriorGenerator.GenerateWarriors(10).ToArray();

            var arena = new GameArena();
            arena.AddWarriors(warriors);

            var game = new Game(arena);
            game.Start();
        }
    }
}
