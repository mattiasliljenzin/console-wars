using System;

namespace aw_console_wars.Warriors
{
    public class SuperWarrior : Warrior
    {
        public SuperWarrior()
        {
            Name = "Fredrik Lindqvist";
        }

        public override string Name { get; set; } 
        public override IWarriorAttributes Attributes { get; set; } = new SuperWarriorAttributes();
    }
}