using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8_BezierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Graphics g = CreateGraphics();
            g.DrawBezier(Pens.Magenta,
            new Point(200, 150), // start point
            new Point(100, 200), // control point one
            new Point(300, 200), // control point two
            new Point(200, 250)); // end point


            //Graphics g = CreateGraphics();
            Point[] pts = {
                new Point(30, 30), // 시작점
                new Point(60, 30), new Point(30, 60), // 제어점
                new Point(60, 60), // 끝점 및 시작점
                new Point(90, 60), new Point(60, 90), // 제어점
                new Point(90, 90), // 끝점 및 시작점
                new Point(120, 90), new Point(90, 120), // 제어점
                new Point(120, 120), // 끝점 및 시작점
                new Point(150, 120), new Point(120, 150), // 제어점
                new Point(150, 150), // 끝점
            };
            g.DrawBeziers(Pens.DeepPink, pts);
        }
    }
}
