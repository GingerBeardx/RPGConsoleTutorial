using RPGConsoleTutorial.Items.Models;
using System.Collections.Generic;

namespace RPGConsoleTutorial.Adventures.Models
{
    public class Chest
    {
        public bool Locked = false;
        public Trap Trap;
        public List<Item> Treasure;
        public int Gold;
    }
}
