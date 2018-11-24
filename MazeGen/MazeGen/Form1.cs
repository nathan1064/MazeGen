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
        const int mazeSize = 20;
        Pen defaultPen = new Pen(Color.Black, 3);

        void DrawInverseMaze(Maze maze, Graphics paper)
        {
            for (int i = 0; i < maze.size; i++)
            {
                for (int j = 0; j < maze.size; j++)
                {
                    if (maze.adjacencyList[i, j, 0])
                        paper.DrawLine(defaultPen, (800/maze.size) * i + 40, (800 / maze.size) * j + 40, (800 / maze.size) * (i + 1) + 40, (800 / maze.size) * j + 40);
                    if (maze.adjacencyList[i, j, 1])
                        paper.DrawLine(defaultPen, (800 / maze.size) * i + 40, (800 / maze.size) * j + 40, (800 / maze.size) * i + 40, (800 / maze.size) * (j + 1) + 40);
                }
            }
        }

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
            Maze testMaze = new Maze(mazeSize);

            DrawInverseMaze(testMaze, paper);
        }

        //"Solve Maze" button click event
        private void buttonSolve_Click(object sender, EventArgs e)
        {

        }
    }
}
