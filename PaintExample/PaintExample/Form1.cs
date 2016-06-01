using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintExample
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
            pen1 = new Pen(Color.Black, 3);
            fill1 = new SolidBrush(Color.Black);
            fill2 = new SolidBrush(Color.White);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(fill1, new Rectangle(231, 168, 300, 70));
            g.FillRectangle(fill1, new Rectangle(291, 118, 240, 90));
            g.FillRectangle(fill2, new Rectangle(321, 140, 40, 30));
            g.FillRectangle(fill2, new Rectangle(441, 140, 40, 30));
            g.FillRectangle(fill2, new Rectangle(407, 119, 2, 120));
            g.DrawEllipse(pen1, new Rectangle(292, 234, 50, 50));
            g.DrawEllipse(pen1, new Rectangle(452, 234, 50, 50));
           // g.FillRectangle(fill2, )
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location.ToString());
        }
    }
}
