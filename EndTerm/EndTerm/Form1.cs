using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndTerm
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush fill1, fill2;
        Pen pen1;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            fill1 = new SolidBrush(Color.Red);
            fill2 = new SolidBrush(Color.Blue);
            pen1 = new Pen(Color.Black, 3);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location.ToString());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(fill1, new Rectangle(321, 100, 50, 50));
            Point[] p = { new Point(345, 150), new Point(295, 200), new Point(395, 200) };
            g.FillPolygon(fill2, p);
            g.DrawLine(pen1, 325, 200, 325, 250);
            g.DrawLine(pen1, 360, 200, 360, 250);
            g.DrawLine(pen1, 365, 171, 417, 147);
            g.DrawLine(pen1, 324, 171, 275, 147);
        }
    }
}
