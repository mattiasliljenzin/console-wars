using System;

namespace aw_console_wars.Warriors
{
    public class SuperWarrior : Warrior
    {
        public SuperWarrior()
        {
            Attributes = new SuperWarriorAttributes();
            Name = "Fredrik Lindqvist";
        }

        public override string Name { get; set; } 
        
    }
}