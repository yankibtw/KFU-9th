using System;

namespace Homework_9
{
    class CustomGame : IGame
    {
        private readonly string customGameName;
        private IGame customGame;

        public CustomGame(IGame customGame, string customGameName)
        {
            this.customGame = customGame;
            this.customGameName = customGameName;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{customGameName}");
        }
    }
}
