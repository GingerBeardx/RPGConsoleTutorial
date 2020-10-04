using RPGConsoleTutorial.Adventures;
using RPGConsoleTutorial.Adventures.Interfaces;
using RPGConsoleTutorial.Entities.Interfaces;
using RPGConsoleTutorial.Entities.Models;
using RPGConsoleTutorial.Game.Interfaces;
using System;

namespace RPGConsoleTutorial.Game
{
    public class GameService : IGameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;

        private Character character;

        public GameService(IAdventureService AdventureService,
            ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }
        public bool StartGame(Adventure adventure = null)
        {
            try
            {
                if (adventure == null)
                {
                    adventure = adventureService.GetInitialAdventure();
                }

                Console.Clear();
                Console.WriteLine();

                // Create title banner
                for (int i = 0; i < adventure.Title.Length + 4; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                Console.Write($"| {adventure.Title} |\n");
                for (int i = 0; i < adventure.Title.Length + 4; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n{adventure.Description.ToUpper()}");
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                var charactersInRange = characterService.GetCharactersInRange(adventure.MinLevel, adventure.MaxLevel);

                if (charactersInRange.Count == 0)
                {
                    Console.WriteLine("Sorry, you do not have any characters in the range level of the adventure you are trying to play.");
                    return false;
                }
                else
                {
                    Console.WriteLine("WHO DOTH WISH TO CHANCE DEATH?");
                    var characterCount = 0;
                    foreach (var character in charactersInRange)
                    {
                        Console.WriteLine($"#{characterCount} : {character.Name} : Level - {character.Level} : Class - {character.Class}");
                        characterCount++;
                    }
                }
                character = characterService.LoadCharacter(charactersInRange[Convert.ToInt32(Console.ReadLine())].Name);
                Console.WriteLine($"You have chosen {character.Name} to go on this adventure!");

                Monster myMonster = new Monster(); // Don't need - kill for next level

            }
            catch (Exception ex)
            {
                Console.WriteLine($"KaBOOOM!!!! Orcs did it again! Something went wrong! {ex.Message}");
            }
            return true;
        }
    }
}
