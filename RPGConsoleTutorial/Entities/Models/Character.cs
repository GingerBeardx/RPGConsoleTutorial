using RPGConsoleTutorial.Items.Interfaces;
using System.Collections.Generic;

namespace RPGConsoleTutorial.Entities.Models
{
    public class Character
    {
        public string Name;
        public int Level;
        public Abilities Abilities;
        public int Gold;
        public string Background;
        public int InventoryWeight;
        public List<string> AdventuresPlayed;
        public bool IsAlive;
        public int ArmorClass;
        public List<IItem> Inventory;
        public int HitPoints;
        public CharacterClass Class;
    }

    public class Abilities
    {
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Inteligence;
        public int Wisdom;
        public int Charisma;
    }

    public enum CharacterClass
    {
        Fighter,
        Theif,
        Mage,
        Priest
    }
}
