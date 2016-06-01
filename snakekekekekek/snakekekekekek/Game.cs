using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snakekekekekek
{
    class Game
    {
        public enum Direction { up, down, left, right };
        public static Direction direction;
        public static int speed = 100;
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public static bool GameOver = false;

        public Game()
        {
            Init();
            Play();

        }
        public void Init()
        {
            food.SetNewPosition();
            wall.Level(Wall.lvl);
            while (Food.FoodinSnake() == true || Food.FoodinWall() == true)
            {
                food.SetNewPosition();
            }

            while (Game.snake.CollisionWithWall())
            {
                Snake.SnakeNewPosition();
            }
        }

        public void Play()
        {
            Console.SetWindowSize(80, 30);
            Thread t = new Thread(MoveSnake);
            t.Start();
            while (!GameOver)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = Direction.up;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = Direction.down;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = Direction.left;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Direction.right;
                        break;
                    case ConsoleKey.F2:
                        Save();
                        break;
                    case ConsoleKey.F3:
                        Resume();
                        break;
                }
            }
        }
        public void MoveSnake(object state)
        {
            while (!GameOver)
            {
                if (direction == Direction.left)
                    snake.move(-1, 0);
                if (direction == Direction.right)
                    snake.move(1, 0);
                if (direction == Direction.up)
                    snake.move(0, -1);
                if (direction == Direction.down)
                    snake.move(0, 1);
                Draw();

                Thread.Sleep(speed);
            }
           
        }
        public static void EndGame()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("          "+"Try again!");
            Console.ReadKey();

        }
        public static void Draw()
        {
            //Console.Clear();
            Display.display();
            food.Draw();
            snake.Draw();
            if(Wall.lvl == 1)
                wall.Draw();
        }
        public void Save()
        {
            snake.Save();
            food.Save();
            wall.Save();
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }
    }
}