using RPGConsoleTutorial.Adventures.Models;
using System.Collections.Generic;

namespace RPGConsoleTutorial.Adventures
{
    public class Adventure
    {
        public string GUID;
        public string Title;
        public string Description;
        public int CompletionXPReward;
        public int CompletionGoldReward;
        public int MaxLevel;
        public int MinLevel;
        public List<Room> Rooms;
        public Adventure()
        {

        }
    }
}
