using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Red, 10);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] p = { new Point(20, 20), new Point(30, 30), new Point(40, 40)};
            g.DrawCurve(pen, p);
        }
    }
}
