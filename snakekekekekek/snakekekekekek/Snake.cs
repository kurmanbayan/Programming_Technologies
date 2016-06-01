﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakekekekekek
{
    [Serializable]
    class Snake : Drawer
    {

        public static int score = 0;
        public Snake()
        {
            color = ConsoleColor.White;
            sign = 'o';
            body.Add(new Point(10, 10));

        }


        public void move(int dx, int dy)
        {
            Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
            Console.Write(" ");

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x == -1) Game.EndGame(); 
            if (body[0].y == -1) Game.EndGame();
            if (body[0].x == 71) Game.EndGame();
            if (body[0].y == 31) Game.EndGame();

            if (SnakeinSnake() == true)
            {
                Game.GameOver = true;
                Game.EndGame();
            }
            if (CollisionWithWall() == true) 
            {
                Game.GameOver = true;
                Game.EndGame();
            }
            if (body[0].x == Game.food.body[0].x &&
                body[0].y == Game.food.body[0].y)
            {
                body.Add(new Point(0, 0));


                Game.food.SetNewPosition();
                while (Food.FoodinSnake() == true || Food.FoodinWall() == true)
                {
                    Game.food.SetNewPosition();
                }
                score++;

                if (score % 3 == 0)
                {
                    Game.snake.body.Clear(); 
                    Game.wall.Level(++Wall.lvl);
                    Console.Clear();
                    Game.wall.Draw();
                    SnakeNewPosition();
                    Game.food.SetNewPosition();
                }

            }
        }
        public static void SnakeNewPosition()
        {
            Game.snake.body.Clear();
            Game.snake.body.Add(new Point(new Random().Next(3, 69), new Random().Next(4, 19)));

        }
        public static bool SnakeinSnake()
        {
            for (int i = 1; i < Game.snake.body.Count; i++)
            {
                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    return true;
            }
            return false;
        }
        public bool CollisionWithWall()
        {
            for (int i = 0; i < Game.wall.body.Count; i++)
            {
                if (body[0].x == Game.wall.body[i].x &&
                    body[0].y == Game.wall.body[i].y)
                    return true;
            }
            return false;
        }
    }
}