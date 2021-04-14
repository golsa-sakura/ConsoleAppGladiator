using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationManager am = new ApplicationManager();
            am.StartGame();
            // am.DisplayMenu();
            am.SelectAction();
        }
    }
}
