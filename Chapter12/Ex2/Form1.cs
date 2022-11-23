using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Ex2
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
            LinearGradientBrush b = new LinearGradientBrush(new Point(0, 0), new Point(40, 30), Color.Blue, Color.Red);
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
    }
}
