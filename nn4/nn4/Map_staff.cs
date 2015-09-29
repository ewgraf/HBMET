using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn4
{
    class Map_staff
    {
        public struct map_generation_info
        {
            public int map_width;
            public int map_heigth;
            public int things;  // lootable
            public int max_steps;
            public int walls_concentration;
        }
        public static int[,] generate_map(map_generation_info m_g_i)
        {
            int[,] map = new int[m_g_i.map_width, m_g_i.map_heigth];

            Random r = new Random();

            int count = 10000;
            int max_count = map.Length;
            int chanse_from = 1;
            int chanse_to = 5;  //m_g_i.walls_concentration
            int concentration = 100 - m_g_i.walls_concentration;
            double a;
            //double b = Math.Abs(a - m_g_i.walls_concentration);
            while (true)
            {
                a = (100.0 * count) / max_count;
                if (Math.Abs(a - concentration) <= 5)
                    break;
                map = new int[m_g_i.map_width, m_g_i.map_heigth];
                for (int i = 0; i < m_g_i.map_width; i++)
                {
                    map[i, 0] = 1;
                    map[i, m_g_i.map_heigth - 1] = 1;
                    if (i < m_g_i.map_heigth)
                    {
                        map[0, i] = 1;
                        map[m_g_i.map_width - 1, i] = 1;
                    }
                }
                count = 0;
                for (int i = 0; i < m_g_i.map_width; i++)
                {
                    if (r.Next(chanse_from, chanse_to) == 1)
                    {
                        int t = r.Next(1, m_g_i.map_heigth - 1);
                        for (int j = 0; j < t; j++)
                        {
                            map[i, j] = 1;
                            count++;
                        }
                    }
                }
                for (int j = 0; j < m_g_i.map_heigth; j++)
                {
                    if (r.Next(chanse_from, chanse_to) == 1)
                    {
                        int t = r.Next(1, m_g_i.map_width - 1);
                        for (int i = 0; i < t; i++)
                        {
                            map[i, j] = 1;
                            count++;
                        }
                    }
                }
                for (int i = 0; i < m_g_i.map_width; i++)
                {
                    if (r.Next(chanse_from, chanse_to) == 1)
                    {
                        int t = r.Next(1, m_g_i.map_heigth - 1);
                        for (int j = m_g_i.map_heigth - 1; j > t; j--)
                        {
                            map[i, j] = 1;
                            count++;
                        }
                    }
                }
                for (int j = 0; j < m_g_i.map_heigth; j++)
                {
                    if (r.Next(chanse_from, chanse_to) == 1)
                    {
                        int t = r.Next(1, m_g_i.map_width - 1);
                        for (int i = m_g_i.map_width - 1; i > t; i--)
                        {
                            map[i, j] = 1;
                            count++;
                        }
                    }
                }
            }

            while (m_g_i.things > 0)
            {
                for (int j = 0; j < m_g_i.map_heigth; j++)
                {
                    for (int i = 0; i < m_g_i.map_width; i++)
                    {
                        if (map[i, j] == 1 && m_g_i.things > 0)
                        {
                            if (r.Next(1, m_g_i.map_width * m_g_i.map_heigth / 10) == 1)
                            {
                                if (map[i, j] != 2)
                                {
                                    map[i, j] = 2;
                                    m_g_i.things--;
                                }
                            }
                        }
                    }
                }
            }

            return map;
        }

        public static void go_up(ref int x, ref int y, int[,] map)
        {
            if (--y >= 0 && map[x, y] != 0) { } else y++;
        }

        public static void go_down(ref int x, ref int y, int[,] map)
        {
            if (++y < map.GetLength(1) && map[x, y] != 0) { } else y--;
        }

        public static void go_left(ref int x, ref int y, int[,] map)
        {
            if (--x >= 0 && map[x, y] != 0) { } else x++;
        }

        public static void go_right(ref int x, ref int y, int[,] map)
        {
            if (++x < map.GetLength(0) && map[x, y] != 0) { } else x--;
        }

        private static string get_map(int[,] map, int x, int y)
        {
            string _out = "";

            int[,] map_local = new int[map.GetLength(0), map.GetLength(1)];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++) { map_local[i, j] = map[i, j]; }
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (!((Math.Abs(x - i) <= 4) && (Math.Abs(y - j) <= 3)))
                    {
                        map_local[i, j] = 3;
                    }
                }
            }
            for (int j = 0; j < map.GetLength(1); j++)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    if (map_local[i, j] == 0)
                    {
                        _out += '█';
                    }
                    if (map_local[i, j] == 1)
                    {
                        _out += '▓';
                    }
                    if (map_local[i, j] == 2)
                    {
                        _out += '°';
                    }
                    if (map_local[i, j] == 3)
                    {
                        _out += '░';
                    }
                }
                _out += '\n';
            }
            return _out;
        }
    }
}

