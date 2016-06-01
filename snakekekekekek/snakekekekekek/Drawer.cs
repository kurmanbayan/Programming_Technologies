using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace snakekekekekek
{
    [Serializable]
    class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();

        public Drawer() { }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                if (p.x > 0 && p.y > 0 && p.x < Console.WindowWidth - 2 && p.y < Console.WindowHeight - 2)
                {
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign);
                }
            }
        }

        public void Save()
        {
            string fileName = "";
            if (sign == '*')
                fileName = "food.dat";
            if (sign == '#')
                fileName = "wall.dat";
            if (sign == 'o')
                fileName = "snake.dat";
            
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, this);
            fs.Close();
        }

        public void Resume()
        {
            string fileName = "";
            if (sign == '*')
                fileName = "food.dat";
            if (sign == '#')

                fileName = "wall.dat";
            if (sign == 'o')
                fileName = "snake.dat";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            if (sign == '*')
                Game.food = bf.Deserialize(fs) as Food;
            if (sign == '#')
                Game.wall = bf.Deserialize(fs) as Wall;

            if (sign == 'o')
                Game.snake = bf.Deserialize(fs) as Snake;

            fs.Close();

        }
    }
}