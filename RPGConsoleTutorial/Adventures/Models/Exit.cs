namespace RPGConsoleTutorial.Adventures.Models
{
    public class Exit
    {
        public bool Locked = false;
        public int LeadsToRoomNumber;
        public Riddle Riddle;
        public CompassDirection WallLocation;
    }

    public enum CompassDirection
    {
        North,
        East,
        Soth,
        West
    }
}
