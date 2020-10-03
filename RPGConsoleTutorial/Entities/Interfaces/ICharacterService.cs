using RPGConsoleTutorial.Entities.Models;
using System.Collections.Generic;

namespace RPGConsoleTutorial.Entities.Interfaces
{
    public interface ICharacterService
    {
        public Character LoadCharacter(string name);

        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20);
    }
}
