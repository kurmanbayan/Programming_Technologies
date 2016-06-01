using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ssssssnake
{
    [Serializable]
    class Food : Drawer
    {
        public Food()
        {

        }
        public Food(char sign, ConsoleColor color) : base(sign, color) { }


        public void SetNewPosition()
        {
            int x = new Random().Next(0, 48);
            int y = new Random().Next(0, 48);
            while (IsOnWallOrOnSnake(x, y))
            {
                x = new Random().Next(0, 48);
                y = new Random().Next(0, 48);
            }
            body[0].x = x;
            body[0].y = y;
        }
        public bool IsOnWallOrOnSnake(int x, int y)
        {
            foreach (Point p in Game.wall.body)
            {
                if (x == p.x && y == p.y) return true;
            }
            foreach (Point p in Game.snake.body)
            {
                if (x == p.x && y == p.y) return true;
            }
            return false;
        }
    }
}