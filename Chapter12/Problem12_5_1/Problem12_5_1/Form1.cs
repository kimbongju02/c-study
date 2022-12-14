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
            if (this.pointList.Count < 2)
            {
                return;
            }


            if (radioButton1.Checked)
                e.Graphics.DrawLines(Pens.Black, this.pointList.ToArray<Point>());
            else if (radioButton2.Checked)
                e.Graphics.DrawPolygon(Pens.Black, this.pointList.ToArray<Point>());
            else if (radioButton3.Checked)
                e.Graphics.DrawCurve(Pens.Black, this.pointList.ToArray<Point>());
            else
            {
                if (pointList.Count < 3)
                    return;
                e.Graphics.DrawClosedCurve(Pens.Black, pointList.ToArray<Point>());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
