using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4calc
{
    public partial class Form1 : Form
    {
        private Calc calc = new Calc();
        public double memNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Clear();    
            Button b = sender as Button;
            display.Text += b.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (display.Text.Length > 0)
            {
                calc.first = double.Parse(display.Text);
                calc.operation = b.Text;
                display.Text = "0"; 
            }
        }

        private void result_click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                if (calc.Result == 0)
                {
                    calc.second = double.Parse(display.Text);
                    calc.Calculate();
                    display.Text = calc.Result.ToString();
                }
                else
                if (calc.Result > 0 && calc.operation == "+")
                {
                    calc.Result += calc.second;
                    display.Text = calc.Result.ToString();
                }
                else
                if (calc.Result > 0 && calc.operation == "-")
                {
                    calc.Result -= calc.second;
                    display.Text = calc.Result.ToString();
                }
                else
                if (calc.Result > 0 && calc.operation == "×")
                {
                    calc.Result *= calc.second;
                    display.Text = calc.Result.ToString();
                }
                else
                if (calc.Result > 0 && calc.operation == "÷")
                {
                    calc.Result /= calc.second;
                    display.Text = calc.Result.ToString();
                }
            }
        }

        private void clear_all(object sender, EventArgs e)
        {
            calc.first = 0;
            calc.second = 0;
            calc.Result = 0;
            calc.operation = "";
            display.Text = "0";
        }

        private void backspace_click(object sender, EventArgs e)
        {
            if (display.Text.Length >= 2)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
            else
            if (display.Text.Length < 2)
            {
                display.Text = "0";   
            }
        }
        private void clear_recent_input(object sender, EventArgs e)
        {
            display.ResetText();
            display.Text = "0";                
        }

        private void plus_minus(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                if (display.Text.Contains("-"))
                    display.Text = display.Text.Remove(0, 1);
                else
                    display.Text = "-" + display.Text;
            }
        }

        private void sqrt(object sender, EventArgs e)
        {
            if (display.Text.Length > 0) { 
                double root = Math.Sqrt(Convert.ToDouble(display.Text));
                display.Text = Convert.ToString(root);
            }
        }

        private void square(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                double sqr = Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text);
                display.Text = Convert.ToString(sqr);
            }
        }

        private void cube(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                double qb = Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text);
                display.Text = Convert.ToString(qb);
            }
        }

        private void nfac(object sender, EventArgs e)
        {
            int nf = 1;
            if (display.Text.Length > 0)
            {
                for (int i = 1; i <= Convert.ToInt64(display.Text); i++)
                {
                    nf = nf * i;
                }
                display.Text = Convert.ToString(nf);
            }
        }

        private void onetox(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                double one = 1 / Convert.ToDouble(display.Text);
                display.Text = Convert.ToString(one);
            }
        }

        private void powx(object sender, EventArgs e)
        {
            int px = 1;
            if (display.Text.Length > 0)
            {
                for (int i = 0; i < Convert.ToInt64(display.Text); i++)
                {
                    px = px * 10;
                }
                display.Text = Convert.ToString(px);
            }
        }

        private void memsave(object sender, EventArgs e)
        {
            if (display.Text.Length > 0) {
                double M = Convert.ToDouble(display.Text);
            }
        }

        private void memory(object sender, EventArgs e)
        {
            Button a = sender as Button;
            string memop = a.Text;
            switch (memop)
            {
                case "MC":
                    memNum = 0;
                    break;
                case "MS":
                    memNum = Convert.ToDouble(display.Text);
                    break;
                case "MR":
                    display.Text = Convert.ToString(memNum);
                    break;
                case "M+":
                    memNum += Convert.ToDouble(display.Text);
                    break;
                case "M-":
                    memNum -= Convert.ToDouble(display.Text);
                    break;
            }
        }

        private void point(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
            {
                display.Text += ",";
            }
        }
    }
}