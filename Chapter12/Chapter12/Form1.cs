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

namespace Chapter12
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
            HatchBrush b = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.Green);
            g.FillRectangle(b, ClientRectangle); // 사용자 영역을 이미지로 채움
            b.Dispose();
        }
    }
}
