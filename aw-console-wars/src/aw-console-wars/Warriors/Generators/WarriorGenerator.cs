using System.Collections.Generic;
using MyNamespace;

namespace aw_console_wars.Warriors.Generators
{
    public class WarriorGenerator
    {
        public IEnumerable<Warrior> GenerateWarriors(int numberOfWarriors)
        {
            GameOutput.Report($"Generating {numberOfWarriors} warriors!");

            for (var i = 0; i < numberOfWarriors; i++)
            {
                if (i == 1)
                {
                    yield return new SuperWarrior();
                }
                else
                {
                    yield return new BasicWarrior
                    {
                        Name = NameGenerator.GetRandomName()
                    };
                }

            }
        }
    }
}