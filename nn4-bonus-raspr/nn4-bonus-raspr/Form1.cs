using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nn4_bonus_raspr
{
    public partial class Form1 : Form
    {
        public struct map_generation_info
        {
            public int map_width;
            public int map_heigth;
            public int things;  // lootable
            public int max_steps;
            public int walls_concentration;
        }
        map_generation_info m_g_i = new map_generation_info();
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //int[,] sees = new int[4, 4] {{ 892, 266,  100, 391 },
            //                             { 171, 1216, 382, 353 },
            //                             { 282, 410,  944, 202 },
            //                             { 303, 230,  412, 1312}};
            //int[,] sont = new int[4, 4] {{ 863, 323,  30,  364 },
            //                             { 129, 1154, 273, 231 },
            //                             { 249, 182,  703, 128 },
            //                             { 339, 128,  256, 1214}};
            //// z, y, x: map[0, 0, 2] == 100;
            //int[, ,] map = new int[2, 4, 4] {   {{ 892, 266,  100, 391 },
            //                                     { 171, 1216, 382, 353 },
            //                                     { 282, 410,  944, 202 },
            //                                     { 303, 230,  412, 1312}},

            //                                    {{ 863, 323,  30,  364 },
            //                                     { 129, 1154, 273, 231 },
            //                                     { 249, 182,  703, 128 },
            //                                     { 339, 128,  256, 1214}}   };
            //Hi_Square3Dtmp();
            Funk1();
        }

        private void Hi_Square3Dtmp()
        {
            //4050.284
            int[, ,] map = new int[2, 4, 4] {   {{ 892, 266,  100, 391 },
                                                 { 171, 1216, 382, 353 },
                                                 { 282, 410,  944, 202 },
                                                 { 303, 230,  412, 1312}},

                                                {{ 863, 323,  30,  364 },
                                                 { 129, 1154, 273, 231 },
                                                 { 249, 182,  703, 128 },
                                                 { 339, 128,  256, 1214}}   };
            int[] col_sum = new int[4];
            int[] row_sum = new int[4];
            int[] depth_sum = new int[2];
            int summa = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int z = 0; z < 2; z++)
                    {
                        row_sum[x] += map[z, y, x];
                        col_sum[y] += map[z, y, x];
                        depth_sum[z] += map[z, y, x];
                        summa += map[z, y, x];
                    }
                }
            }

            double[,,] fe_ij = new double[2, 4, 4];
            double hi = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int z = 0; z < 2; z++)
                    {
                        fe_ij[z, y, x] = (row_sum[x] * col_sum[y]) / (summa);

                        hi += (  (map[z, y, x] - fe_ij[z, y, x]) *
                                 (map[z, y, x] - fe_ij[z, y, x])    )
                                                                        / fe_ij[z, y, x];
                    }
                }
            }
            var result = hi;
        }

        private double Hi_Square3D(int[,,] map)
        {
            double result = 0d;

            int test = map[0, 0, 2];

            int[] col_sum = new int[4];
            int[] row_sum = new int[4];
            int[] depth_sum = new int[2];
            int summa = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int z = 0; z < 1; z++)
                    {
                        row_sum[x] += map[z, y, x];
                        col_sum[y] += map[z, y, x];
                        depth_sum[z] += map[z, y, x];
                        summa += map[z, y, x];
                    }
                }
            }

            double[,,] fe_ij = new double[2, 4, 4];
            double hi = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int z = 0; z < 1; z++)
                    {
                        fe_ij[z, y, x] = row_sum[x] * col_sum[y] * depth_sum[z] / summa;
                        hi += ( (map[z, y, x] - fe_ij[z, y, x]) * (map[z, y, x] - fe_ij[z, y, x]) ) / fe_ij[z, y, x];
                    }
                }
            }
            result = hi;
            return result;
        }

        private void Funk1()
        {
            string[] maps = System.IO.Directory.GetFiles("Карты", "карта-*.txt");
            List<int> watcher = new List<int>();
            StringBuilder sb = new StringBuilder();
            m_g_i.max_steps = 42;
            m_g_i.map_width = m_g_i.map_heigth = 15;
            for (int epoch = 0; epoch < maps.Length; epoch++)
            {
                int[,] raspr_big = new int[15, 15];
                m_g_i.things = 15;
                #region experiment
                int map_id = r.Next(0, maps.Length);
                string[] current_map = System.IO.File.ReadAllLines(maps[map_id]);
                int[,] map = new int[m_g_i.map_width, m_g_i.map_heigth];
                for (int j = 0; j < m_g_i.map_heigth; j++)
                {
                    for (int i = 0; i < m_g_i.map_width; i++)
                    {
                        map[i, j] = Int32.Parse(current_map[j][i].ToString());
                    }
                }
                #endregion
                /* for experiment = 0 -> 100 */

                List<int> f0 = new List<int>();
                var raspr_small = new int[5, 5];

                #region Get-25-f0-from-raspr_big[,]
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        int sum = 0;

                        for (int i = y * 3; i < y * 3 + 3; i++)
                        {
                            for (int j = x * 3; j < x * 3 + 3; j++)
                            {
                                if (map[i, j] == 1)
                                    sum++;
                            }
                        }
                        f0.Add(sum);
                        raspr_small[x, y] = sum*5;
                        sb.Append(sum + " ");
                    }
                    sb.Append('\n');
                }
                #endregion

                //var hit = Funk(raspr_small);

                int[] col_sum = new int[5];
                int[] row_sum = new int[5];
                int summa = 0;
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        row_sum[x] += raspr_small[x, y];
                        col_sum[y] += raspr_small[x, y];
                        summa += raspr_small[x, y];
                    }
                }

                double[,] fe_ij = new double[5, 5];
                double hi = 0;
                #region Get-hi-square
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        fe_ij[x, y] = row_sum[x] * col_sum[y] / summa;
                        hi += (raspr_small[x, y] - fe_ij[x, y]) * (raspr_small[x, y] - fe_ij[x, y]) / fe_ij[x, y];
                    }
                }
                #endregion

                watcher.Add((int)hi);
                //sb.Append(hi + "\n");
                //MessageBox.Show(sb.ToString());
            }

            //MessageBox.Show(sb.ToString());
            //sb.Clear();

            System.IO.File.WriteAllLines(
                "a.out",
                watcher.Select(d => d.ToString()).ToArray()
            );
        }
    }
}
