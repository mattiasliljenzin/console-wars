using System;
using System.Linq;
using aw_console_wars.Warriors.Generators;

namespace aw_console_wars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var warriorGenerator = new WarriorGenerator();
            var warriors = warriorGenerator.GenerateWarriors(15).ToArray();

            var arena = new GameArena();
            arena.AddWarriors(warriors);

            var game = new GameSimulator(arena);
            game.Start();

            Console.WriteLine();
            Console.WriteLine("Game simulation complete. Press any key to exit...");
            Console.ReadLine();
        }
    }
}
