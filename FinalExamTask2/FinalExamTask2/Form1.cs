﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor == Color.Red)
            {
                b.BackColor = Color.Yellow;
            }
            else
            if (b.BackColor == Color.Yellow)
            {
                b.BackColor = Color.Blue;
            }
            else
            if (b.BackColor == Color.Blue)
            {
                b.BackColor = Color.Red;
            }
           
        }
    }
}
