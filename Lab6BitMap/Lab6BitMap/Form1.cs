using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab6BitMap
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen, pen1;
        SolidBrush fill, fill1, fill2, fill3, fill4;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            fill = new SolidBrush(Color.DarkBlue);
            pen = new Pen(Color.Yellow, 3);
            fill1 = new SolidBrush(Color.Yellow);
            fill2 = new SolidBrush(Color.Green);
            fill3 = new SolidBrush(Color.White);
            fill4 = new SolidBrush(Color.Red);
            pen1 = new Pen(Color.Black, 2);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(fill, 0, 0, this.Width, this.Height);
            Point[] a = { new Point(300, 200), new Point(400, 200), new Point(350, 170)};
            g.FillRectangle(fill1, new Rectangle(300, 200, 100, 40));
            g.FillPolygon(fill1, a);
            Point[] b = { new Point(300, 240), new Point(400, 240), new Point(350, 270) };
            g.FillPolygon(fill1, b);
            g.FillRectangle(fill2, new Rectangle(345, 205, 10, 30));
            Point[] c = { new Point(335, 205), new Point(365, 205), new Point(350, 190) };
            g.FillPolygon(fill2, c);
            g.FillEllipse(fill3, new Rectangle(103, 96, 33, 30));
            g.FillEllipse(fill3, new Rectangle(177, 239, 33, 30));
            g.FillEllipse(fill3, new Rectangle(511, 144, 33, 30));
            g.FillEllipse(fill3, new Rectangle(580, 375, 33, 30));
            g.FillEllipse(fill3, new Rectangle(664, 231, 33, 30));
            g.FillEllipse(fill3, new Rectangle(133, 360, 33, 30));
            g.FillEllipse(fill3, new Rectangle(362, 348, 33, 30));
            g.FillRectangle(fill3, new Rectangle(511, 4, 260, 40));
            g.DrawRectangle(pen, new Rectangle(511, 4, 260, 40));
            g.FillRectangle(fill2, new Rectangle(346, 109, 8, 8));
            Point[] tr1 = { new Point(346, 117), new Point(354, 117), new Point(350, 125) };
            g.FillPolygon(fill2, tr1);
            Point[] tr2 = { new Point(346, 109), new Point(354, 109), new Point(350, 101) };
            g.FillPolygon(fill2, tr2);
            Point[] tr3 = { new Point(354, 109), new Point(354, 117), new Point(362, 113) };
            g.FillPolygon(fill2, tr3);
            Point[] tr4 = { new Point(346, 109), new Point(346, 117), new Point(338, 113) };
            g.FillPolygon(fill2, tr4);
            Point[] ast1 = { new Point(521, 282), new Point(561, 282), new Point(541, 312) };
            g.FillPolygon(fill4, ast1);
            Point[] ast2 = { new Point(521, 302), new Point(561, 302), new Point(541, 272) };
            g.FillPolygon(fill4, ast2);
            Point[] ast3 = { new Point(257, 352), new Point(297, 352), new Point(277, 382) };
            g.FillPolygon(fill4, ast3);
            Point[] ast4 = { new Point(257, 372), new Point(297, 372), new Point(277, 342) };
            g.FillPolygon(fill4, ast4);
            Point[] ast5 = { new Point(75, 202), new Point(115, 202), new Point(95, 232) };
            g.FillPolygon(fill4, ast5);
            Point[] ast6 = { new Point(75, 222), new Point(115, 222), new Point(95, 192) };
            g.FillPolygon(fill4, ast6);
            g.DrawRectangle(pen1, new Rectangle(0, 0, this.Width, this.Height));

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location.ToString());
        }
    }
}
