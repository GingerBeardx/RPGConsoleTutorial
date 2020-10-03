using Newtonsoft.Json;
using RPGConsoleTutorial.Entities.Interfaces;
using RPGConsoleTutorial.Entities.Models;
using System;
using System.IO;

namespace RPGConsoleTutorial.Entities
{
    public class CharacterService : ICharacterService
    {
        public Character LoadInitialCharacter()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var initialCharacter = new Character();

            if (File.Exists($"{basePath}\\conan.json"))
            {
                var direcotry = new DirectoryInfo(basePath);
                var initialJsonFile = direcotry.GetFiles("conan.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }
            }

            return initialCharacter;
        }        
    }
}
