using Newtonsoft.Json;
using RPGConsoleTutorial.Adventures.Interfaces;
using System;
using System.IO;

namespace RPGConsoleTutorial.Adventures
{
    public class AdventureService : IAdventureService
    {
        public Adventure GetInitialAdventure()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{basePath}\\initial.json"))
            {
                var direcotry = new DirectoryInfo(basePath);
                var initialJsonFile = direcotry.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                }
            }

            return initialAdventure;
        }
    }
}
