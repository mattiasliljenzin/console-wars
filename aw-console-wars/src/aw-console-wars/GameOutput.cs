using System;

namespace aw_console_wars
{
    public static class GameOutput
    {
        public static void Report(string text)
        {
            Console.WriteLine($"[GameOutput]: {text}");
        }        
    }


}