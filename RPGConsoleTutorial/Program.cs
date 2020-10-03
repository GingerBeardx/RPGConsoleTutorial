using System;

namespace RPGConsoleTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeTitle();
            MakeMainMenu();
            Console.ReadLine();
        }
        private static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("***************************************************");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("*      ┌─┐┌─┐┌┐┌┌─┐┌─┐┬  ┌─┐  ┌─┐┬─┐┌─┐┬ ┬┬       *");
            Console.WriteLine("*      │  │ ││││└─┐│ ││  ├┤   │  ├┬┘├─┤││││       *");
            Console.WriteLine("*      └─┘└─┘┘└┘└─┘└─┘┴─┘└─┘  └─┘┴└─┴ ┴└┴┘┴─┘     *");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("***************************************************");
        }
        private static void MakeMainMenu()
        {
            Console.WriteLine("\n\n(S)tart a new game");
            Console.WriteLine("(L)Load a saved game");
            Console.WriteLine("(C)reate a new character");
            var MainMenuChoice = Console.ReadLine().ToUpper();

            Console.WriteLine($"YOU CHOSE - {MainMenuChoice}");

            if (MainMenuChoice == "S" || MainMenuChoice == "L" || MainMenuChoice == "C")
            {
                Console.WriteLine("Thanks!  This choice did nothing!");
            }
            else
            {
                Console.WriteLine("You have chosen....poorly!");
            }
        }
    }
}
