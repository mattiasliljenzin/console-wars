namespace aw_console_wars.Warriors
{
    public class DefaultWarriorAttributes : IWarriorAttributes
    {
        public int MaxHealth { get; } = 100;
        public int Strength { get; } = 50;
        public int Dexterity { get; } = 50;
        public int Constitution { get; } = 50;
    }
}

