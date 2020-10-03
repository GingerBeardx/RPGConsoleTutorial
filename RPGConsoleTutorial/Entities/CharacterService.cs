using Newtonsoft.Json;
using RPGConsoleTutorial.Entities.Interfaces;
using RPGConsoleTutorial.Entities.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace RPGConsoleTutorial.Entities
{
    public class CharacterService : ICharacterService
    {
        

        public Character LoadCharacter(string name)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var chosenCharacter = new Character();

            if (File.Exists($"{basePath}\\{name}.json"))
            {
                var direcotry = new DirectoryInfo(basePath);
                var characterJsonFile = direcotry.GetFiles($"{name}.json");

                using (StreamReader fi = File.OpenText(characterJsonFile[0].FullName))
                {
                    chosenCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }
            }
            else
            {
                throw new Exception("Character not found.");
            }
            return chosenCharacter;
        }
        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var charactersInRange = new List<Character>();

            try
            {
                var directory = new DirectoryInfo(basePath);

                foreach (var file in directory.GetFiles($"*.json"))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        var potentialCharacterInRange = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                        if (potentialCharacterInRange.IsAlive &&
                            (potentialCharacterInRange.Level >= minLevel &&
                            potentialCharacterInRange.Level <= maxLevel))
                        {
                            charactersInRange.Add(potentialCharacterInRange);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dear God, what have you done! Goblins have devoured you! {ex.Message}");
            }
            return charactersInRange;
            
        }
    }
}
