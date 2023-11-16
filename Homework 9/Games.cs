using System;

namespace Homework_9
{
    class Games
    {
        public class Beach : IGame
        {
            public void PlayGame()
            {
                Console.WriteLine("Пляжная игра");
            }
        }
        public class Mousetrap : IGame
        {
            public void PlayGame()
            {
                Console.WriteLine("Игра мышеловка");
            }
        }
        public class Sea : IGame
        {
            public void PlayGame()
            {
                Console.WriteLine("Морская игра");
            }
        }
        public class Fishing : IGame
        {
            public void PlayGame()
            {
                Console.WriteLine("Рыбалка");
            }
        }
        public class Postmen : IGame
        {
            public void PlayGame()
            {
                Console.WriteLine("Игра почтальоны");
            }
        }
        public class Slide : IGame
        {
            public void PlayGame()
            {
                Console.WriteLine("Игра горки");
            }
        }
    }
}
