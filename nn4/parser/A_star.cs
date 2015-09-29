using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nn4
{
    class A_star
    {
        private bool[,] map;
        private SearchParameters sp;

        /// <summary>
        /// Outputs three examples of path finding to the Console.
        /// </summary>
        /// <remarks>The examples have copied from the unit tests!</remarks>
        public List<Point> Find(int[,] iMap, Point S, Point F)
        {
            // Start with a clear map (don't add any obstacles)
            InitializeMap(iMap, S, F);
            PathFinder pathFinder = new PathFinder(sp);
            List<Point> path = pathFinder.FindPath();
            return path;
        }

        /// <summary>
        /// Displays the map and path as a simple grid to the console
        /// </summary>
        /// <param name="title">A descriptive title</param>
        /// <param name="path">The points that comprise the path</param>
        private void ShowRoute(string title, IEnumerable<Point> path)
        {
            Console.WriteLine("{0}\r\n", title);
            //for (int y = this.map.GetLength(1) - 1; y >= 0 ; y--) // Invert the Y-axis so that coordinate 0,0 is shown in the bottom-left
            for (int y = 0; y < this.map.GetLength(1); y++) // Invert the Y-axis so that coordinate 0,0 is shown in the bottom-left
            {
                for (int x = 0; x < this.map.GetLength(0); x++)
                {
                    if (this.sp.StartLocation.Equals(new Point(x, y)))
                        // Show the start position
                        Console.Write('S');
                    else if (this.sp.EndLocation.Equals(new Point(x, y)))
                        // Show the end position
                        Console.Write('F');
                    else if (this.map[x, y] == false)
                        // Show any barriers
                        Console.Write('░');
                    else if (path.Where(p => p.X == x && p.Y == y).Any())
                        // Show the path in between
                        Console.Write('*');
                    else
                        // Show nodes that aren't part of the path
                        Console.Write('·');
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates a clear map with a start and end point and sets up the search parameters
        /// </summary>
        private void InitializeMap(int[,] iMap, Point S, Point F)
        {
            this.map = IntToBool(iMap);
            //var tmp = BoolToString(map);
            //var tmp1 = ParseIntArrayToString(iMap);
            this.sp = new SearchParameters(S, F, map);
        }

        private bool[,] IntToBool(int[,] iMap)
        {
            //bool[,] _out = new bool[Map.GetLength(1), Map.GetLength(0)];
            //for (int i = 0; i < Map.GetLength(1); i++)
            //    for (int j = 0; j < Map.GetLength(0); j++)
            //        _out[i, j] = Map[j, i] == 0 || Map[j, i] == 2;
            //return _out;
            bool[,] _out = new bool[iMap.GetLength(0), iMap.GetLength(1)];
            for (int i = 0; i < iMap.GetLength(0); i++)
                for (int j = 0; j < iMap.GetLength(1); j++)
                    _out[i, j] = iMap[i, j] == 1 || iMap[i, j] == 2 || iMap[i, j] == 3;
            return _out;
        }
        private string[] BoolToString(bool[,] iMap)
        {
            int width = iMap.GetLength(0);
            int heigth = iMap.GetLength(1);
            string[] oMap = new string[heigth];
            string tmp = "";
            for (int j = 0; j < heigth; j++)
                for (int i = 0; i < width; i++)
                    oMap[j] += iMap[i, j] ? "1" : "0";
                    //switch(iMap[i, j])
                    //{
                    //    case "8":
                    //        tmp = 
                    //        break;
                    //}
            return oMap;
        }
        private string[] ParseIntArrayToString(int[,] iMap)
        {
            int width = iMap.GetLength(0);
            int heigth = iMap.GetLength(1);
            string[] oMap = new string[heigth];
            for (int j = 0; j < heigth; j++)
                for (int i = 0; i < width; i++)
                    oMap[j] += iMap[i, j].ToString();
            return oMap;
        }
    }
}


