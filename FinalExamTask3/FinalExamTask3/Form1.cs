using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamTask3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        //Bitmap btm;
        bool clicked = false; 

        public int last_number = 0;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int first = int.Parse(textBox1.Text);
            first += trackBar1.Value;
            textBox1.Text = Convert.ToString(first);
            Refresh();
            
        }

        private void trackBar1_MouseMove(object sender, MouseEventArgs e)
        {
             
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if (last_number > 0)
            {
                g.DrawEllipse(pen, Width / 2 - 50, Height / 2 - 50, int.Parse(textBox1.Text) + last_number, int.Parse(textBox1.Text) + last_number);
            }
                        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            last_number = int.Parse(textBox1.Text);
            clicked = true;
        }
    }
}
