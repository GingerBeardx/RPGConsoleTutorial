using RPGConsoleTutorial.Adventures;
using RPGConsoleTutorial.Entities;
using RPGConsoleTutorial.Game;
using System;

namespace RPGConsoleTutorial
{
    class Program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = 
            new GameService(adventureService, characterService);
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
                        gameService.StartGame();
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
                        Console.WriteLine("\nYou have chosen....poorly! Please try again.");
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
            Console.WriteLine("You are loading a game, great job!");
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("You are creating a character, yay!");
        }
    }
}
