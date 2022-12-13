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

namespace Problem12_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Point> pointList = new List<Point>();//마우스 포인터 위치 저장할 리스트
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pointList.Add(e.Location);
                Refresh();
            }
            else
            {
                this.pointList = new List<Point>();
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (this.pointList.Count < 2)
            {
                return;
            }
            if(radioButton1.Checked == true)
                e.Graphics.DrawLines(Pens.Black, this.pointList.ToArray());
            else if(radioButton2.Checked == true)
                e.Graphics.DrawPolygon(Pens.Black, this.pointList.ToArray());
            else if(radioButton3.Checked == true)
                e.Graphics.DrawCurve(Pens.Black, this.pointList.ToArray());
            else if(radioButton4.Checked == true)
                e.Graphics.DrawClosedCurve(Pens.Black, this.pointList.ToArray());
        }
    }
}
