﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Graphics paper = pictureBox1.CreateGraphics(); //Initialize the graphics object "paper"
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
