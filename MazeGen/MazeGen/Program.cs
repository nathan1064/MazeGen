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
        //A boolean adjacency list which tells us if a cell is connected to the cell left of or below itself
        public bool[,,] adjacencyList = new bool[20,20,2];

        public Maze()
        {
            //Initialize all cells as connected
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    adjacencyList[i, j, 0] = true;
                    adjacencyList[i, j, 1] = true;
                }
            }
        }
    }
}
