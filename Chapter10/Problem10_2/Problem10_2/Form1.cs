using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Mouse
{
    public partial class Form1 : Form
    {
        private int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(this.Form1_MouseWheel);
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            textBox1.Text = (e.Delta > 0 ? num++ : num--).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num=0;
            textBox1.Text = num.ToString();
        }
    }
}
