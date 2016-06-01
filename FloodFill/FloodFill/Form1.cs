using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloodFill
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap btm;
        Color color = Color.Red;
        Queue<Point> q = new Queue<Point>();
        bool[,] used = new bool[501, 301];

        public Form1()
        {
            InitializeComponent();
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
            pictureBox1.Image = btm;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(new Pen(Color.Blue, 3), 10, 10, 100, 100);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            fill(e.Location);
        }
        public void fill(Point cur)
        {
            Color clicked_color = btm.GetPixel(cur.X, cur.X);
            checkNeighbors(cur.X, cur.Y, clicked_color);
            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                checkNeighbors(p.X + 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y + 1, clicked_color);
                checkNeighbors(p.X - 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y - 1, clicked_color);
            }
            pictureBox1.Refresh();
        }
        public void checkNeighbors(int x, int y, Color clicked_color)
        {
            if (x > 0 && y > 0 && x < pictureBox1.Width && y < pictureBox1.Height)
            {
                if (used[x, y] == false && btm.GetPixel(x, y) == clicked_color)
                {
                    used[x, y] = true;
                    q.Enqueue(new Point(x, y));
                    btm.SetPixel(x, y, color);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }
    }
}
