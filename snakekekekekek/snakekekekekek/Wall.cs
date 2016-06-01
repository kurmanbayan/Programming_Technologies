using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakekekekekek
{
    [Serializable]
    class Wall : Drawer
    {
        public Wall()
        {
            color = ConsoleColor.Red;
            sign = '#';
        }
        public static int lvl = 1;
        public void Level(int lvl)
        {
            string FileName = string.Format(@"C:\Users\Lenovo\me\snakekekekekek\snakekekekekek\bin\Debug\lvl{0}.txt", lvl);
            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            body.Clear();

            string[] Rows = sr.ReadToEnd().Split('\n');
            for (int i = 0; i < Rows.Length; i++)
                for (int j = 0; j < Rows[i].Length; j++)
                    if (Rows[i][j] == '#')
                        body.Add(new Point(j, i));

        }


    }
}