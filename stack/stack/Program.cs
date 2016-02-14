using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            dirTree(@"C:\Users\Lenovo\me");
        }
        static void dirTree(string path)
        {
            Stack<string> dir = new Stack<string>();
            dir.Push(path);
            while (dir.Count > 0)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                string[] subDir = Directory.GetDirectories(dir.Pop());
                foreach (string q in subDir)
                {
                    Console.WriteLine(q + ": " + Directory.GetFiles(q).Length);
                    dir.Push(q);
                    Console.ReadKey();
                }
            }
        }
    }
}
