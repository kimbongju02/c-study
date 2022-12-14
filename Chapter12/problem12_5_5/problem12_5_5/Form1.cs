﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace problem12_5_5
{
    public partial class Form1 : Form
    {
        FontFamily fontFamily = new FontFamily("Arial");
        FontFamily[] fontFamilies;
        InstalledFontCollection installedFontCollection = new InstalledFontCollection();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontFamilies = installedFontCollection.Families;
            int count = fontFamilies.Length;
            for (int j = 0; j < count; ++j)
            {
                fontBox.Items.Add(fontFamilies[j].Name);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Font f = new Font(fontBox.Text, (float)fontsize.Value, FontStyle.Regular);
            g.DrawString(textBox1.Text, f, Brushes.Black, 117, 130);
            g.Dispose();
        }
    }
}
