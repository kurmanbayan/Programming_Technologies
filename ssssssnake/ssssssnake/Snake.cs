using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ssssssnake
{
    [Serializable]
    class Snake : Drawer
    {
        public Snake()
        {

        }

        public Snake(char sign, ConsoleColor color) : base(sign, color) { }

        public override void Draw()
        {
            for (int i = 0; i < body.Count; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(body[i].x, body[i].y);
                    Console.Write(sign);
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(body[i].x, body[i].y);
                    Console.Write(sign);
                }
            }


        }
        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (Game.snake.body[0].x == Game.food.body[0].x &&
               Game.snake.body[0].y == Game.food.body[0].y)
            {
                Game.snake.body.Add(new Point { x = Game.food.body[0].x, y = Game.food.body[0].y });
                Game.food.SetNewPosition();
            }
            CollisionWithWallOrWithSnake();
        }
        public void CollisionWithWallOrWithSnake()
        {
            if (Game.snake.body[0].x > Console.WindowWidth) Game.snake.body[0].x = 0;
            if (Game.snake.body[0].y > Console.WindowHeight) Game.snake.body[0].y = 0;
            if (Game.snake.body[0].x < 0) Game.snake.body[0].x = Console.WindowWidth;
            if (Game.snake.body[0].y < 0) Game.snake.body[0].y = Console.WindowHeight;
        }
    }
}