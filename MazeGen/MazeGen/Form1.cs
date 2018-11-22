using System;
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
        Pen defaultPen = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
        }

        //"Clear" button click event
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        //"Generate Maze" button click event
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics(); //Initialize the graphics object "paper"
        }

        //"Solve Maze" button click event
        private void buttonSolve_Click(object sender, EventArgs e)
        {

        }
    }
}
