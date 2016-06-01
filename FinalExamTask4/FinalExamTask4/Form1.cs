using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamTask4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen1;
        SolidBrush brush1, brush2;
        Timer timer;

        float x = 0;
        float y = 0;
        float w = 100;
        float h = 100;

        float dx = 0;
        float dy = 0;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen1 = new Pen(Color.Red, 10);
            brush1 = new SolidBrush(Color.Black);
            brush2 = new SolidBrush(Color.Red);
            timer = new Timer();
            timer.Tick += new EventHandler(moveObject);
            timer.Start();
        }

        private void moveObject(object sender, EventArgs e)
        {
            if (x + w > Width)
            {
                dx -= 10;
            }
            if (x < 0)
            {
                dx += 10;
            }

            x += dx;
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(brush1, x + 10, y + 100, w, h-30);
            g.FillRectangle(brush2, x + 30, y + 70, 60, 30);
            
        }
    }
}
