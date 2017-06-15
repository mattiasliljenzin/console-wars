using System.Collections.Generic;

namespace aw_console_wars.Warriors.Generators
{
    public class WarriorGenerator
    {
        public IEnumerable<Warrior> GenerateWarriors(int numberOfWarriors)
        {
            GameOutput.Report($"Generating {numberOfWarriors} warriors!");

            for (var i = 0; i < numberOfWarriors; i++)
            {
                yield return null;
            }
        }
    }
}