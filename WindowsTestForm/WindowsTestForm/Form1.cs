using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTestForm
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush, brush1;
        Pen pen;
        Timer time;
            
        enum Position
        {
            Left, Right, Up, Down
        }

        private Position objPos;
        int x = 0;
        int y = 0;
        int w = 50;
        int h = 50;

        int dx = 10;
        int dy = 10;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Red, 4);
            brush = new SolidBrush(Color.Blue);
            brush1 = new SolidBrush(Color.Black);
            time = new Timer();
            time.Tick += new EventHandler(MoveObject);
            time.Start();
            //objPos = Position.Down;
        }
        private void MoveObject(object sender, EventArgs e)
        {
            if (w + x > Width)
            {
                dx = -10;
            }
            else if (x < 0)
            {
                dx = 10;
            }
            if (y + h > Height)
            {
                dy = -10;
            }
            else if (y < 0)
            {
                dy = 10;
            }

            if (objPos == Position.Right) 
            {
                x += dx;
            }
            if (objPos == Position.Left)
            {
                x -= dx;
            }
            if (objPos == Position.Up)
            {
                y -= dy;
            }
            if (objPos == Position.Down)
            {
                y += dy;
            }
            Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g.FillRectangle(brush, x + 10, y + 188, 300, 60);
            //g.FillRectangle(brush, x + 95, y + 118, 215, 90);
            //g.DrawEllipse(pen, x + 68, y + 247, 30, 30);
            //g.DrawEllipse(pen, x + 239, y + 247, 30, 30);
            g.DrawEllipse(pen, new Rectangle(x, y, w, h));  
              
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad6)
            {
                objPos = Position.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                objPos = Position.Right;
            }    
            if (e.KeyCode == Keys.Up)
            {
                objPos = Position.Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                objPos = Position.Down;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location.ToString());
        }
    }
}
