using RPGConsoleTutorial.Adventures;

namespace RPGConsoleTutorial.Game.Interfaces
{
    public interface IGameService
    {
        bool StartGame(Adventure adventure = null);
    }
}