using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPrep3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        Timer time;

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
            pen = new Pen(Color.Black, 10);
            time = new Timer();
            time.Tick += new EventHandler(MoveObject);
            time.Start();
        }

        private void MoveObject(object sender, EventArgs e)
        {
            if (x + w >= Width)
            {
                dx -= 10;
            }
            else if (x <= 0)
            {
                dx += 10;
            }

            x += dx;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawEllipse(pen, x, y, w, h);
        }
    }
}
