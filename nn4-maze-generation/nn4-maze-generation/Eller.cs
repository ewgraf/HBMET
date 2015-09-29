using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn4_maze_generation
{
    class Eller
    {
        //static char MAZE_WALL = '▓';
        //static char MAZE_PATH = '░';
        static char MAZE_WALL = '0';
        static char MAZE_PATH = '1';
        static int UNDETERMINED = -2;
        static int SET_WALL = -1;
        int rows;           //the rows in the representative feild
        int cols;           //the cols in the representative feild
        int act_rows;       //the actual number of rows in the maze
        int act_cols;       //the actual number of cols in the maze
        char[][] feild;     //the feild where the maze is being made
        int[] current;      //the current row, excluding the outer walls
        int[] next;         //the next row, excluding the outer walls
        int numSet;         //track set numbers to make sure not to duplicate
        Random rand;

        /* constructor */
        public Eller (int nRows, int nCols, Random nRand)
        {
            rand = nRand;
            act_rows = nRows;
            act_cols = nCols;
            rows = act_rows * 2 + 1;
            cols = act_cols * 2 + 1;
            feild = new char[rows][];

            for (int i = 0; i < cols; i++ )
            {
                feild[i] = new char[rows];
            }

            current = new int[act_cols * 2 - 1];
            next = new int[act_cols * 2 - 1];
            /* Sets the maze to filled */
            for (int i = 0; i < feild[0].Length; i++)
            {
                for (int j = 0; j < feild.Length; j++)
                {
                    feild[i][j] = MAZE_WALL;
                }
            }

            for (int i = 0; i < next.Length; i++)
            {
                next[i] = UNDETERMINED;
            }

            /* initialize the first row to unique sets */
            for (int i = 0; i < current.Length; i += 2)
            {
                current[i] = i / 2 + 1;
                if (i != current.Length - 1)
                    current[i + 1] = SET_WALL;
            }
            numSet = current[current.Length - 1];
        }

        public void makeMaze()
        {
            for (int q = 0; q < act_rows - 1; q++)
            {
                //for all rows but the last one
                if (q != 0)
                {
                    /* get the current row from the last iteration */
                    for (int i = 0; i < current.Length; i++)
                    {
                        current[i] = next[i];
                        next[i] = UNDETERMINED;
                    }
                }

                joinSets();
                makeVerticalCuts();

                /* populate the rest of the next row */
                for (int j = 0; j < current.Length; j += 2)
                {
                    if (next[j] == UNDETERMINED)
                        next[j] = ++numSet;
                    if (j != current.Length - 1)
                        next[j + 1] = SET_WALL;
                }

                /* record the current row onto the feild */
                for (int k = 0; k < current.Length; k++)
                {
                    if (current[k] == SET_WALL)
                    {
                        feild[2 * q + 1][k + 1] = MAZE_WALL;
                        feild[2 * q + 2][k + 1] = MAZE_WALL;
                    }
                    else
                    {
                        feild[2 * q + 1][k + 1] = MAZE_PATH;
                        if (current[k] == next[k])
                        {
                            feild[2 * q + 2][k + 1] = MAZE_PATH;
                        }
                    }
                }
            }
            makeLastRow();
            //makeOpenings();
        }

        private void joinSets()
        {
            /* Randomly join sets together */
            for (int i = 1; i < current.Length - 1; i += 2)
            {
                //checks only at wall locations
                /* make sure they are eligible to be combined:
                 * they have wall between then
                 * they are not part of the same set
                 *
                 * then get a random boolean to pick if they actually get combine
                 * */
                if (current[i] == SET_WALL && current[i - 1] != current[i + 1] /*&& (rand.Next(0, 2) == 0)*/)
                {
                    current[i] = 0; // take away the barrier
                    int old = Math.Max(current[i - 1], current[i + 1]);
                    int next = Math.Min(current[i - 1], current[i + 1]);
                    /* Combine the two sets into 1 (the smallest numbered set)
                     * */
                    for (int j = 0; j < current.Length; j++)
                    {
                        if(current[j] == old)
                            current[j] = next;
                    }
                }
            }
        }

        /* Randomly pick vertical paths for each set, making sure there
         * is at least 1 vertical path per set
         * */
        private void makeVerticalCuts()
        {
            int begining;       //the begining of the section (inclusive)
            int end;            //the end of teh section (inclusive)
            bool madeVertical; 
            /* tracks if a vertical path has been made
             * in the section
             * */
            int i;
            begining = 0;
            do
            {
                /* find the end of this section */
                i = begining;
                while (i < current.Length - 1 && current[i] == current[i + 2])
                {
                    i += 2;
                }
                end = i;
                /* loop trying to cut a vertical path in the section until it
                * is sucessful at least 1 time in the section
                */
                madeVertical = false;
                do
                {
                    for (int j = begining; j <= end; j += 2)
                    {
                        if (rand.Next(0, 2) == 0)
                        {
                            next[j] = current[j];
                            madeVertical = true;
                        }
                    }
                } while (!madeVertical);
                begining = end + 2; //go to the next section in the row
            } while (end != current.Length - 1);
        }

        private void makeLastRow()
        {
            /* get the current row from the last iteration */
            for (int i = 0; i < current.Length; i++)
            {
                current[i] = next[i];
            }
            for (int i = 1; i < current.Length - 1; i += 2)
            {
                if (current[i] == SET_WALL && current[i - 1] != current[i + 1])
                {
                    current[i] = 0;
                    int old = Math.Max(current[i - 1], current[i + 1]);
                    int next = Math.Min(current[i - 1], current[i + 1]);
                    /* combine the two sets into 1 (the smallest numbered
                    * set)
                    */
                    for (int j = 0; j < current.Length; j++)
                    {
                        if(current[j] == old)
                            current[j] = next;
                    }
                }
            }
            /* add the last row to the feild */
            for (int k = 0; k < current.Length; k++)
            {
                if(current[k] == SET_WALL)
                {
                    feild[rows - 2][k + 1] = MAZE_WALL;
                }else{
                    feild[rows - 2][k + 1] = MAZE_PATH;
                }
            }
        }

        public void makeOpenings()
        {
            //Random rand_1 = new Random();   //two different random number generators
            //Random rand_2 = new Random();   //just in case
            //a random location for the entrance and exit
            int entrance_row = rand.Next(act_rows - 1) * 2 + 1;
            int exit_row = rand.Next(act_rows - 1) * 2 + 1;
            //clear the location
            feild[entrance_row][0] = MAZE_PATH;
            feild[exit_row][cols - 1] = MAZE_PATH;
        }

        public char[][] getMazeCharArray()
        {
            return feild;
        }

        public string getMaze()
        {
            //int top = 0, right = 0, bottom = 0, left = 0;
            StringBuilder s = new StringBuilder();
            for (int i = 1; i < cols - 1; i++)
            {
                for (int j = 1; j < rows - 1; j++)
                {
                    s.Append(feild[i][j]);
                }
                if (i + 1 < rows)
                    //s.Append("\n\n");
                    s.Append(Environment.NewLine);
            }
            //for (int y = 1; y < cols - 1; y++)
            //{
            //    for (int x = 1; x < rows - 1; x++)
            //    {
            //        if (feild[x][y] == MAZE_WALL)
            //            continue;

            //        if (y - 1 >= 1 && feild[x][y - 1] == MAZE_PATH)
            //            top++;
            //        if (x + 1 <= cols - 1 && feild[x + 1][y] == MAZE_PATH)
            //            right++;
            //        if (y + 1 <= rows - 1 && feild[x][y + 1] == MAZE_PATH)
            //            bottom++;
            //        if (x - 1 >= 1 && feild[x - 1][y] == MAZE_PATH)
            //            left++;
            //    }
            //}
            //s.AppendLine(top.ToString());
            //s.AppendLine(right.ToString());
            //s.AppendLine(bottom.ToString());
            //s.AppendLine(left.ToString());
            return s.ToString();
        }
    }
}
