using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Paint
{
    public enum Shape { Pencil, Rectangle, Circle, Line, Triangle, Eraser, FloodFill, Hexagon, Trapezoid, Fill, Cube};

    class Drawer
    {
        public Graphics g;
        public GraphicsPath path;
        public Bitmap btm;
        public PictureBox picture;
        public Shape shape;
        public Pen pen;

        public bool paintStarted = false;
        public Point prev;

        public Queue<Point> q = new Queue<Point>();
        public bool[,] used = new bool[806, 418];
        public Color color = Color.YellowGreen;
        

        public Drawer(PictureBox p)
        {
            this.picture = p;
            pen = new Pen(Color.Red);
            OpenImage("");
            picture.Paint += Picture_Paint;
        }

        public void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        public void saveLastPath()
        {
            if (path != null)
            {
                g.DrawPath(pen, path);
                path = null;
            }
        }
            
        public void Draw(Point cur)
        {
            switch (shape)
            {
                case Shape.Cube:
                    path = new GraphicsPath();
                    Point[] p = { new Point(prev.X, prev.Y), new Point(cur.X + 50, prev.Y), new Point(cur.X, cur.Y - 50),
                    new Point(prev.X - 50, cur.Y - 50)
                   };
                    path.AddPolygon(p);
                    break;
                case Shape.Hexagon:
                    path = new GraphicsPath();
                    Point[] hexagon = { new Point(prev.X, prev.Y), new Point(cur.X, prev.Y), new Point(cur.X + 100, cur.Y - (cur.Y - prev.Y) / 2),
                        new Point(cur.X, cur.Y), new Point(prev.X, cur.Y), new Point (prev.X - 100, cur.Y - (cur.Y - prev.Y)/2) };
                    path.AddPolygon(hexagon);
                    break;
                case Shape.Pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Rectangle:
                    path = new GraphicsPath();
                    int pointX = prev.X;
                    int pointY = prev.Y;
                    if (cur.X < prev.X)
                    {
                        pointX = cur.X;
                    }
                    if (cur.Y < prev.Y)
                    {
                        pointY = cur.Y;
                    }
                    path.AddRectangle(new Rectangle(pointX, pointY, Math.Abs(cur.X - prev.X), Math.Abs(cur.Y - prev.Y)));
                    break;
                case Shape.Circle:
                    path = new GraphicsPath();
                    path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                    break;
                case Shape.Line:
                    path = new GraphicsPath();
                    path.AddLine(prev, cur);
                    break;
                case Shape.Triangle:
                    path = new GraphicsPath();
                    Point[] points = { new Point(prev.X, prev.Y), new Point(cur.X, cur.Y), new Point(cur.X - 2*(cur.X - prev.X), cur.Y) };
                    path.AddPolygon(points);
                    break;
                case Shape.Eraser:
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(prev.X - 15, prev.Y - 15, 30, 30));
                    prev = cur;
                    break;
                default:
                    break;         
            }
            picture.Refresh();  
        }

        public void fill(Point cur)
        {
            for (int i = 0; i < 806; ++i)
                for (int j = 0; j < 418; ++j)
                    used[i,j] = false;
            Color clicked_color = btm.GetPixel(cur.X, cur.Y);
            checkNeighbors(cur.X, cur.Y, clicked_color);
            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                checkNeighbors(p.X + 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y + 1, clicked_color);
                checkNeighbors(p.X - 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y - 1, clicked_color);
            }
            picture.Refresh();
        }
        public void checkNeighbors(int x, int y, Color clicked_color)
        {
            if (x > 0 && y > 0 && x < picture.Width && y < picture.Height)
            {
                if (used[x, y] == false && btm.GetPixel(x, y) == clicked_color) 
                {
                    used[x, y] = true;
                    q.Enqueue(new Point(x, y));
                    btm.SetPixel(x, y, color);
                }
            }
        }
        public void OpenImage(string filename)
        {
            btm = filename == "" ? new Bitmap(picture.Width, picture.Height) : new Bitmap(filename);
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
            picture.Image = btm;
        }

        public void SaveImage(string filename)
        {
            btm.Save(filename);
        }

    }
}
