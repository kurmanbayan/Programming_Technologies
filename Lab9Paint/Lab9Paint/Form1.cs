using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Paint
{
    public partial class Form1 : Form
    {
        Drawer drawer;
       
        
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox1);
        }
       
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawer.prev = e.Location;
                drawer.paintStarted = true;
                if (drawer.shape == Shape.Fill)
                {
                    drawer.fill(e.Location);
                   // drawer.picture.Image = drawer.btm;
                }
            }
  
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawer.paintStarted)
            {
                drawer.Draw(e.Location);    
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.paintStarted = false;
            drawer.saveLastPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Pencil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Rectangle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Circle;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Line;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            colorDialog1.ShowDialog();
            drawer.pen = new Pen(colorDialog1.Color, num);
            drawer.color = colorDialog1.Color;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.OpenImage(openFileDialog1.FileName);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               drawer.SaveImage(saveFileDialog1.FileName);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            drawer.g.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Triangle;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Eraser;
        }
        
        private void changeButtonSize(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(textBox1.Text);
            Button b = sender as Button;
            if (b.Text == "+")
            {
                if (Convert.ToInt64(textBox1.Text) < 10)
                {
                    num++;
                }
                drawer.pen.Width = num;
            }
            else 
            if (b.Text == "-")
            {
                if (Convert.ToInt64(textBox1.Text) > 0)
                {
                    num--;
                }
                drawer.pen.Width = num;
            }
            textBox1.Text = Convert.ToString(num);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Fill;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Hexagon;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Trapezoid;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            drawer.shape = Shape.Cube;
        }
    }
}
