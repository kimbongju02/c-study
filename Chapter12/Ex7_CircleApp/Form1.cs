using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_CircleApp
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
            Rectangle r = new Rectangle(50, 50, 150, 100); //사각형 왼쪽 끝점 50, 50 /폭 150/ 높이 100/ 원점: 50+75, 50+50
            g.FillEllipse(Brushes.Cyan, r);
            g.DrawEllipse(Pens.Black, r);

            //Graphics g = CreateGraphics();
            Rectangle r2 = new Rectangle(210, 50, 150, 100);// public void DrawArc(Pen p, 외접사각형, 시작 각도, 호의 각도)
            g.FillPie(Brushes.LightGreen, r2, 45, 270);
            g.DrawArc(Pens.Red, r2, 45, 270);

            Point[] pts = {
                new Point(215, 130), new Point(240, 190),
                new Point(300, 215), new Point(240, 240),
                new Point(215, 300), new Point(190, 240),
                new Point(130, 215), new Point(190, 190)
            };
            g.FillClosedCurve(Brushes.Yellow, pts);
            g.DrawClosedCurve(Pens.Red, pts);

        }
    }
}
