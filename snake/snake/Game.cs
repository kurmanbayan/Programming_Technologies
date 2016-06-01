using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Game 
    {
        public static Food food = new Food();
        public  static Wall wall = new Wall();
        public static Snake snake = new Snake();
        public static bool GameOver = false;

        public Game()
        {
            Console.SetWindowSize(67, 31);
            while (!GameOver)
            {
                Draw();
                ConsoleKeyInfo button = Console.ReadKey();
                Console.SetCursorPosition(31, 31);

                Console.WriteLine("Your score is {0}", Game.snake.eatfood);
                if (button.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);
                if (button.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);
                if (button.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);
                if (button.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);
                if (snake.CheckCollisionWithWall());
                    GameOver = true;
                if (button.Key == ConsoleKey.F3)
                    wall.setLevel(2);
                if (button.Key == ConsoleKey.F2)
                    Save();
                if (button.Key == ConsoleKey.F1)
                    Resume();

            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
        public static void Draw()
        {
            Console.Clear();
            wall.Draw();
            food.Draw();
            snake.Draw();

        }
        public void Save()
        {
            snake.Save();
            food.Save();
            snake.Save();
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }
    }
}
