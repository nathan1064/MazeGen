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
        const int mazeSize = 20; //A place holder constant(To be replaced with user input)
        Pen defaultPen = new Pen(Color.Black, 3);

        //This function draws lines between the centers of connected cells, resulting in a visualization similar to a traditional graph
        void DrawInverseMaze(Maze maze, Graphics paper)
        {
            for (int i = 0; i < maze.size; i++)
            {
                for (int j = 0; j < maze.size; j++)
                {
                    if (maze.adjacencyList[i, j, 0])
                        paper.DrawLine(defaultPen, (800f / maze.size) * i + 40, (800f / maze.size) * j + 40, (800f / maze.size) * (i + 1) + 40, (800f / maze.size) * j + 40);
                    if (maze.adjacencyList[i, j, 1])
                        paper.DrawLine(defaultPen, (800f / maze.size) * i + 40, (800f / maze.size) * j + 40, (800f / maze.size) * i + 40, (800f / maze.size) * (j + 1) + 40);
                }
            }
        }

        //This function draws the walls of a maze
        void DrawMaze(Maze maze, Graphics paper)
        {
            paper.DrawRectangle(defaultPen, 20, 20, 800, 800);

            for (int i = 0; i < maze.size; i++)
            {
                for (int j = 0; j < maze.size; j++)
                {
                    if (!maze.adjacencyList[i, j, 0])
                        paper.DrawLine(defaultPen, 20 + (800f / maze.size) * (i + 1), 20 + (800f / maze.size) * j, 20 + (800f / maze.size) * (i + 1), 20 + (800f / maze.size) * (j + 1));
                    if (!maze.adjacencyList[i, j, 1])
                        paper.DrawLine(defaultPen, 20 + (800f / maze.size) * i, 20 + (800f / maze.size) * (j + 1), 20 + (800f / maze.size) * (i + 1), 20 + (800f / maze.size) * (j + 1));
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
        }

        //"Solve Maze" button click event
        private void buttonSolve_Click(object sender, EventArgs e)
        {

        }
    }
}
