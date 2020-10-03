using RPGConsoleTutorial.Adventures;
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
            Console.WriteLine("***************************************************\n\n");
        }
        private static void MakeMainMenu()
        {
            MakeMenuOptions();            
            var inputValid = false;
            
            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        StartGame();
                        inputValid = true;
                        break;
                    case "C":
                        CreateCharacter();
                        inputValid = true;
                        break;
                    case "L":
                        LoadGame();
                        inputValid = true;
                        break;
                    default:
                        Console.WriteLine("\nYou have chosen....poorly!");
                        MakeMenuOptions();
                        inputValid = false;
                        break;
                }                
            }
        }

        private static void MakeMenuOptions()
        {
            Console.WriteLine("\n(S)tart a new game");
            Console.WriteLine("(L)Load a saved game");
            Console.WriteLine("(C)reate a new character");
        }

        private static void LoadGame()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var initialAdventure = new Adventure();
            
            Console.WriteLine("You are loading a game, snap!");
        }

        private static void StartGame()
        {
            Console.WriteLine("You started the game, great job!");
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("You are creating a character, yay!");
        }
    }
}
