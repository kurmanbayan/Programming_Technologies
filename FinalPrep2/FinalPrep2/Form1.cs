using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPrep2
{
    public partial class Form1 : Form
    {
        private CalcComp calc = new CalcComp(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_clicked(object sender, EventArgs e)
        {
            textBox1.Clear();
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (textBox1.Text.Length > 0)
            {
                calc.first = double.Parse(textBox1.Text);
                calc.operation = b.Text;
                
            }
        }

        private void result_click(object sender, EventArgs e)
        {
            
        }
    }
}
