using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake
{
    class Wall: Drawer
    {
        public int levelup = 1;
        public Wall()
        {
            color = ConsoleColor.Red;
            sign = '#';
            setLevel(levelup);
        }
        public void setLevel(int level)
        {
            string fileName = string.Format(@"C:\Users\Lenovo\me\snake\maps\level{0}.txt",level);
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string map = sr.ReadToEnd();
            string[] rows = map.Split('\n');

            body.Clear();
            for (int i = 0; i < rows.Length; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    if (rows[i][j] == '#')
                        body.Add(new Point(j, i));
            for (int i=0; i<66; i++)
                body.Add(new Point(i, 0));
            for (int i = 0; i < 66; i++)
                body.Add(new Point(i, 29));
            for (int i = 0; i < 30; i++)
                body.Add(new Point(0, i));
            for (int i = 0; i < 30; i++)
                body.Add(new Point(66, i));


            sr.Close();
            fs.Close();
        }
    }
}
