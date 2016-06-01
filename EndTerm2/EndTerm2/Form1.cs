using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndTerm2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        Timer time;
        float  x = 0;
        float y = 0;
        float w = 100;
        float h = 100;

        float dx = 10;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Red, 4);
            time = new Timer();
            time.Tick += new EventHandler(move);
            time.Start();
        }


        private void move(object sender, EventArgs e)
        {
            if (x+w > Width)
            {
                dx = -10;
            }
            else if (x < 0)
            {
                dx = 10;
            }
            x += dx;
           
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(pen, x + 10, y + 10, 100, 50);
            g.DrawEllipse(pen, x + 10, y + 60, 30, 30);
            g.DrawEllipse(pen, x + 80, y + 60, 30, 30);
        }
    }
}
