namespace aw_console_wars.Warriors
{
    public class BasicWarrior : Warrior
    {
        public override string Name { get; set; } = "Basic Warrior";
        public override IWarriorAttributes Attributes { get; set; } = new DefaultWarriorAttributes();
    }
}