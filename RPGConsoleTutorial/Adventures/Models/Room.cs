using RPGConsoleTutorial.Entities.Models;
using System.Collections.Generic;

namespace RPGConsoleTutorial.Adventures.Models
{
    public class Room
    {
        public int RoomNumber;
        public string RoomDescription;
        public Trap Trap;
        public List<Monster> Monsters;
        public Chest Chest;
        public Objective FinalObjective;
        public List<Exit> Exits;
    }
}
