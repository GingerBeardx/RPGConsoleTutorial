namespace RPGConsoleTutorial.Adventures.Models
{
    public class Objective
    {
        public ObjectType ObjectType;
    }

    public enum ObjectType
    {
        MonstersInRoom,
        AllMonsters,
        ItemsObtained
    }
}
