using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setSize()
        {
            Size= new Size(300, 500);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Size.Width<300 || Size.Width>500)
                setSize();
            if (Size.Height<300 || Size.Height>700)
                setSize();
        }
    }
