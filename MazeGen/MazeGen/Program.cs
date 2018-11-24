using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


    //The Maze class to store a maze, and methods for both maze generation and solving
    public class Maze
    {
        public bool[,,] adjacencyList; //A boolean adjacency list which tells us if a cell is connected to the cell to the right of or below itself
        public int size; //A size parameter so size is recorded on a per maze basis

        public Maze(int mazeSize)
        {
            size = mazeSize;
            adjacencyList = new bool[mazeSize, mazeSize, 2];

            //Initialize all cells as connected
            for (int i = 0; i < mazeSize; i++)
            {
                for (int j = 0; j < mazeSize; j++)
                {
                    adjacencyList[i, j, 0] = true;
                    adjacencyList[i, j, 1] = true;
                }
            }
            for (int i = 0; i < mazeSize; i++)
            {
                adjacencyList[i, 19, 1] = false;
            }
            for (int j = 0; j < mazeSize; j++)
            {
                adjacencyList[19, j, 0] = false;
            }
        }
    }
}
