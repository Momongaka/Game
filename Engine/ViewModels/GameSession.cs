
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        private Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Daniel";
            CurrentPlayer.Gold = 100000;
        }
    }
}