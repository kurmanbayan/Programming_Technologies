using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        List<PointF> arr = new List<PointF>(); // List of points

        public Pen coord = new Pen(Color.Black, 3); // pen to draw x and y
        public Pen sin = new Pen(Color.Red, 2); // pen to draw the curve
        Timer t = new Timer(); // timer
        int x = 0; // inital value of x 

        Point p1 = new Point(536, 525); // points of coordinates x and y 
        Point p2 = new Point(536, 0);
        Point p3 = new Point(0, 260);
        Point p4 = new Point(1050, 260);
        public Form1()
        {
            
            InitializeComponent();
            arr.Add(new PointF((float)0, (float)260)); // inital point of the curve
            arr.Add(new PointF((float)0, (float)260));
            t.Interval = 50;
            t.Tick += Points;
            t.Start();
        }
        private void Points(object sender, EventArgs e)
        {
            double y = Math.Sin(x++); // value of y
            y = y * 30 + 260; // shifting the point

            
            arr.Add(new PointF((float)x * 20 - 49, (float)y)); // drawing the curve
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            coord.StartCap = LineCap.ArrowAnchor; //drawing arrow
            coord.EndCap = LineCap.Flat;
            e.Graphics.DrawLine(coord, p2, p1);

            coord.EndCap = LineCap.ArrowAnchor;
            coord.StartCap = LineCap.Flat;
            e.Graphics.DrawLine(coord, p3, p4);

            e.Graphics.DrawCurve(sin, arr.ToArray());

            for (int i = 20; i <= 1000; i += 30) //drawing net
            {
                if (i == 260) ;
                else e.Graphics.DrawLine(new Pen(Color.Blue), 1053, i, 0, i);

            }
            for (int i = 8; i <= 10000; i += 33)
            {
                if (i == 536) ;
                else e.Graphics.DrawLine(new Pen(Color.Blue), i, 0, i, 540);

            }

        }

    }
}

