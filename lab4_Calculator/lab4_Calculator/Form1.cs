using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_Calculator
{
    public partial class Form1 : Form
    {

        private Calc calc = new Calc();

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers(object sender, EventArgs e)
        {
            Button b = sender as Button;     
                display.Text += b.Text;        
        }

        private void operation(object sender, EventArgs e)
        {
            Button b = sender as Button;
            calc.first = double.Parse(display.Text);
            calc.operation = b.Text;
            display.Text = "";
            
        }

        private void clear_all(object sender, EventArgs e)
        {
            calc.first = 0;
            calc.second = 0;
            calc.Result = 1;
            calc.operation = "";
            display.Text = "";
        }

        private void result_click(object sender, EventArgs e)
        {
            calc.second = double.Parse(display.Text);
            calc.Calculate();
            display.Text = calc.Result.ToString();
            
        }

        private void point_click(object sender, EventArgs e)
        {
            display.Text += button28.Text;
            if (display.Text.Contains("."))
            {
                return;
            }
            
        }

        private void backspace_click(object sender, EventArgs e)
        {
            if (display.Text.Length>0)
            display.Text = display.Text.Remove(display.Text.Length-1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             this.KeyPreview = true;
        }

        private void clear_recent_input(object sender, EventArgs e)
        {
            display.ResetText();
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
        private void button33_Click(object sender, EventArgs e)
        {

        }

    }
}
