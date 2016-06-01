using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ssssssnake
{
    [Serializable]
    class Drawer
    {
        public char sign;
        public ConsoleColor color;
        public List<Point> body = new List<Point>();

        public Drawer() { }

        public Drawer(char _sign, ConsoleColor _color)
        {
            sign = _sign;
            color = _color;
        }

        public virtual void Draw()
        {
            foreach (Point p in body)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

        public void Save()
        {
            string fileName = "";
            switch (sign)
            {
                case '#':
                    fileName = "wall.ser";
                    break;
                case '$':
                    fileName = "food.ser";
                    break;
                case 'o':
                    fileName = "snake.ser";
                    break;
            }
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            bf.Serialize(fs, this);

            fs.Close();
        }

        public void Resume()
        {
            string fileName = "";
            switch (sign)
            {
                case '#':
                    fileName = "wall.ser";
                    break;
                case '$':
                    fileName = "food.ser";
                    break;
                case 'o':
                    fileName = "snake.ser";
                    break;
            }
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                switch (sign)
                {
                    case '#':
                        Game.wall.body.Clear();
                        Game.wall = bf.Deserialize(fs) as Wall;
                        break;
                    case '$':
                        Game.food.body.Clear();
                        Game.food = bf.Deserialize(fs) as Food;
                        break;
                    case 'o':
                        Game.snake.body.Clear();

                        Game.snake = bf.Deserialize(fs) as Snake;
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }

        }
    }

}