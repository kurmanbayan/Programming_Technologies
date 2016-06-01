using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakekekekekek
{
    class Display
    {
        public static void display()
        {

            Console.SetCursorPosition(5, 1);
            Console.Write("score:" + Snake.score +"   "+ " level: " + Wall.lvl ); 
        }
    }
}