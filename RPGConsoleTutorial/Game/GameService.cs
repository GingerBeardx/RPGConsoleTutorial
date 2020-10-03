using RPGConsoleTutorial.Adventures.Interfaces;
using RPGConsoleTutorial.Entities.Interfaces;
using System;

namespace RPGConsoleTutorial.Game
{
    public class GameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;

        public GameService(IAdventureService AdventureService, 
            ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }
        public void StartGame()
        {
            var initialAdventure = adventureService.GetInitialAdventure();
            var initialCharacter = characterService.LoadInitialCharacter();

            Console.WriteLine($"Adventure : {initialAdventure.Title}");
            Console.WriteLine($"Description : {initialAdventure.Description}");
            Console.WriteLine($"Name: {initialCharacter.Name}");
            Console.WriteLine($"Hit Points: {initialCharacter.HitPoints}");
        }
    }
}
