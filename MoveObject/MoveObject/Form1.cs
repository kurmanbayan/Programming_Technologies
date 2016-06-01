using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        Timer t;

        float x = 0;
        float y = 0;
        float w = 100;
        float h = 100;
        float dx = 10;
        float dy = 10;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Red, 2);
            t = new Timer();
            t.Tick += new EventHandler(MoveObject);
            t.Start();
        }

        private void MoveObject(object sender, EventArgs e)
        {
            if (x + w + 35 > Width)
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(p, x + 30, y + 70, 60, 30);
            g.DrawRectangle(p, x + 10, y + 100, w , h - 50);
            g.DrawEllipse(p, x + 20, y + 135, 30, 30);
            g.DrawEllipse(p, x + 70, y + 135, 30, 30);
        }
    }
}
