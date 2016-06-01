using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake: Drawer
    {

        public Snake()
        {
            color = ConsoleColor.White;
            sign = 'o';
            body.Add(new Point(10.10));
        }
        public int eatfood = 0;
        public void move(int dx, int dy)
        {
            for (int i=body.Count-1; i>0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y)
            {
                eatfood++;
                body.Add(new Point(0, 0));
                Game.food.setNewPosition();
            }
            if (CheckCollisionWithFood())
            {
                Game.food.body.Clear();
                Game.food.setNewPosition();
            }
            if (CheckCollisionWithSnake())
            {
                Game.food.body.Clear();
                Game.food.setNewPosition();
            }
            if (body.Count>3)
            {
                body.Clear();
                body.Add(new Point(10, 10));
                Game.wall.setLevel(Game.wall.levelup + 1);
            }
        }
        public bool CheckCollisionWithWall()
        {
            foreach (Point p in Game.wall.body)
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            return false;
        }
        private bool CheckCollisionWithFood()
        {
            foreach (Point p in Game.wall.body)
                if (p.x == Game.food.body[0].x && p.y == Game.food.body[0].y)
                    return true;
            return false;
        }
        private bool CheckCollisionWithSnake()
        {
            foreach (Point p in Game.snake.body)
                if (p.x == Game.food.body[0].x && p.y == Game.food.body[0].y)
                    return true;
            return false;
        }
    }
}
